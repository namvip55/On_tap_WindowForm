namespace Bai1
{
    public class TinhCuocService
    {
        public bool TinhTien(string donGiaText, string soLuongText, string giamGiaText, out decimal tongTien, out string loi)
        {
            tongTien = 0;

            // Cắt khoảng trắng dư thừa ở hai đầu chuỗi
            donGiaText = donGiaText?.Trim() ?? "";
            soLuongText = soLuongText?.Trim() ?? "";
            giamGiaText = giamGiaText?.Trim() ?? "";

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(donGiaText))
            {
                loi = "Vui lòng nhập đơn giá dịch vụ!";
                return false;
            }

            if (string.IsNullOrEmpty(soLuongText))
            {
                loi = "Vui lòng nhập số lượng khách!";
                return false;
            }

            // Nếu ô giảm giá trống thì mặc định là 0%
            if (string.IsNullOrEmpty(giamGiaText))
            {
                giamGiaText = "0";
            }

            // Kiểm tra tính hợp lệ của Đơn giá
            if (!decimal.TryParse(donGiaText, out decimal donGia) || donGia < 0)
            {
                loi = "Đơn giá phải là số lớn hơn hoặc bằng 0!";
                return false;
            }

            // Kiểm tra tính hợp lệ của Số lượng
            if (!int.TryParse(soLuongText, out int soLuong) || soLuong <= 0)
            {
                loi = "Số lượng khách phải là số nguyên dương lớn hơn 0!";
                return false;
            }

            // Kiểm tra tính hợp lệ của Giảm giá
            if (!decimal.TryParse(giamGiaText, out decimal giamGia) || giamGia < 0 || giamGia > 100)
            {
                loi = "Giảm giá phải là số từ 0% đến 100%!";
                return false;
            }

            // Tính tổng tiền = (Đơn giá * Số lượng) * (100 - % Giảm) / 100
            tongTien = donGia * soLuong * (100m - giamGia) / 100m;
            loi = string.Empty;
            return true;
        }
    }
}