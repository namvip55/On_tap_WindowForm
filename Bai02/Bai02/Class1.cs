using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITSupportApp
{
    public class Class1
    {
        private readonly Form1 f;
        private string duongDanAnh = "";

        public Class1(Form1 form)
        {
            f = form;

            // Đăng ký sự kiện nút bấm
            f.btnTaiAnh.Click += BtnTaiAnh_Click;
            f.btnGui.Click += BtnGui_Click;
            f.btnNhapLai.Click += BtnNhapLai_Click;
        }

        private void BtnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Tệp hình ảnh (*.jpg; *.png)|*.jpg;*.png|Tất cả tệp (*.*)|*.*";
                dlg.Title = "Chọn ảnh chụp lỗi sự cố";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tạo bản sao Bitmap để không khóa file ảnh gốc trên ổ đĩa
                        using (Image img = Image.FromFile(dlg.FileName))
                        {
                            Image anhCu = f.picAnh.Image;
                            f.picAnh.Image = new Bitmap(img);

                            if (anhCu != null)
                                anhCu.Dispose();
                        }

                        duongDanAnh = dlg.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnGui_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(f.txtMaPhieu.Text) || string.IsNullOrWhiteSpace(f.txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phiếu và Người yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy Mức độ ưu tiên từ RadioButton
            string mucDo = f.rbThap.Checked ? "Thấp" :
                           f.rbTrungBinh.Checked ? "Trung bình" : "Khẩn cấp";

            // Lấy Danh sách thiết bị từ CheckBox
            StringBuilder ds = new StringBuilder();
            if (f.cbMayBan.Checked) ds.Append("Máy tính bàn, ");
            if (f.cbLaptop.Checked) ds.Append("Laptop, ");
            if (f.cbMayIn.Checked) ds.Append("Máy in, ");
            if (f.cbDienThoai.Checked) ds.Append("Điện thoại, ");

            string thietBi = ds.Length > 0 ? ds.ToString().TrimEnd(' ', ',') : "Chưa chọn";

            // Gom thông tin phiếu thành chuỗi tóm tắt
            string tomTat =
                $"Mã phiếu: {f.txtMaPhieu.Text.Trim()}\n" +
                $"Người yêu cầu: {f.txtNguoiYeuCau.Text.Trim()}\n" +
                $"Ngày ghi nhận: {f.dtpNgay.Value:dd/MM/yyyy}\n" +
                $"Mức độ ưu tiên: {mucDo}\n" +
                $"Loại sự cố: {f.cboLoaiSuCo.Text}\n" +
                $"Thiết bị ảnh hưởng: {thietBi}\n" +
                $"Ảnh chụp lỗi: {(string.IsNullOrEmpty(duongDanAnh) ? "Chưa tải ảnh" : duongDanAnh)}";

            // Hiển thị bảng tóm tắt
            MessageBox.Show(tomTat, "Thông tin phiếu sự cố IT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu các ô nhập
            f.txtMaPhieu.Clear();
            f.txtNguoiYeuCau.Clear();
            f.dtpNgay.Value = DateTime.Now;

            // Reset RadioButton & ComboBox
            f.rbThap.Checked = true;
            if (f.cboLoaiSuCo.Items.Count > 0)
                f.cboLoaiSuCo.SelectedIndex = 0;

            // Uncheck tất cả CheckBox
            f.cbMayBan.Checked = false;
            f.cbLaptop.Checked = false;
            f.cbMayIn.Checked = false;
            f.cbDienThoai.Checked = false;

            // Xóa ảnh trong PictureBox và giải phóng bộ nhớ
            Image anhCu = f.picAnh.Image;
            f.picAnh.Image = null;
            if (anhCu != null)
                anhCu.Dispose();

            duongDanAnh = "";
            f.txtMaPhieu.Focus();
        }
    }
}