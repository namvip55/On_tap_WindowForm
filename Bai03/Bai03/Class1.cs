using System;
using System.Windows.Forms;

namespace ItemListManager
{
    public class Class1
    {
        private readonly Form1 f;

        public Class1(Form1 form)
        {
            f = form;

            // Đăng ký các sự kiện
            f.btnThem.Click += BtnThem_Click;
            f.btnCapNhat.Click += BtnCapNhat_Click;
            f.btnXoaDong.Click += BtnXoaDong_Click;
            f.btnXoaToanBo.Click += BtnXoaToanBo_Click;

            // Đăng ký sự kiện khi click chọn dòng trên ListView
            f.lsvVatTu.SelectedIndexChanged += LsvVatTu_SelectedIndexChanged;

            // Xóa rỗng form khi click ra vùng trống của form hoặc listview
            f.btnLamMoi.Click += (s, e) => LamMoiForm();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            string maVT = f.txtMaVT.Text.Trim();

            // Validate: Không cho phép thêm nếu Mã VT đã tồn tại
            foreach (ListViewItem item in f.lsvVatTu.Items)
            {
                if (item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại trong danh sách!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f.txtMaVT.Focus();
                    return;
                }
            }

            // Tạo dòng mới cho ListView
            ListViewItem newItem = new ListViewItem(maVT);
            newItem.SubItems.Add(f.txtTenVT.Text.Trim());
            newItem.SubItems.Add(f.cboDVT.Text);
            newItem.SubItems.Add(f.txtDonGia.Text.Trim());

            f.lsvVatTu.Items.Add(newItem);
            LamMoiForm();
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (f.lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!KiemTraHopLe()) return;

            ListViewItem selectedItem = f.lsvVatTu.SelectedItems[0];
            string maVT = f.txtMaVT.Text.Trim();

            // Validate xem mã VT mới đổi có bị trùng với dòng KHÁC không
            foreach (ListViewItem item in f.lsvVatTu.Items)
            {
                if (item != selectedItem && item.Text.Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã bị trùng với một mục khác!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Cập nhật dữ liệu
            selectedItem.Text = maVT; // Cột 0 (Mã VT)
            selectedItem.SubItems[1].Text = f.txtTenVT.Text.Trim();
            selectedItem.SubItems[2].Text = f.cboDVT.Text;
            selectedItem.SubItems[3].Text = f.txtDonGia.Text.Trim();

            LamMoiForm();
        }

        private void BtnXoaDong_Click(object sender, EventArgs e)
        {
            if (f.lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị MessageBox xác nhận Yes/No
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa vật tư đang chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                f.lsvVatTu.Items.Remove(f.lsvVatTu.SelectedItems[0]);
                LamMoiForm();
            }
        }

        private void BtnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (f.lsvVatTu.Items.Count == 0) return;

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?",
                "Cảnh báo xóa dữ liệu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                f.lsvVatTu.Items.Clear();
                LamMoiForm();
            }
        }

        private void LsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu có dòng được chọn thì đẩy dữ liệu sang trái
            if (f.lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = f.lsvVatTu.SelectedItems[0];
                f.txtMaVT.Text = item.Text;
                f.txtTenVT.Text = item.SubItems[1].Text;
                f.cboDVT.Text = item.SubItems[2].Text;
                f.txtDonGia.Text = item.SubItems[3].Text;
            }
        }

        private bool KiemTraHopLe()
{
    if (string.IsNullOrWhiteSpace(f.txtMaVT.Text) || 
        string.IsNullOrWhiteSpace(f.txtTenVT.Text) || 
        string.IsNullOrWhiteSpace(f.txtDonGia.Text))
    {
        MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
    }

    // Validate Đơn giá phải là số VÀ phải lớn hơn 0
    if (!decimal.TryParse(f.txtDonGia.Text, out decimal donGia) || donGia <= 0)
    {
        MessageBox.Show("Đơn giá phải là một số hợp lệ và lớn hơn 0!", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        f.txtDonGia.Focus();
        return false;
    }

    return true;
}

        private void LamMoiForm()
        {
            f.txtMaVT.Clear();
            f.txtTenVT.Clear();
            if (f.cboDVT.Items.Count > 0) f.cboDVT.SelectedIndex = 0;
            f.txtDonGia.Clear();

            // Xóa bôi đen trên ListView
            if (f.lsvVatTu.SelectedItems.Count > 0)
            {
                f.lsvVatTu.SelectedItems[0].Selected = false;
            }

            f.txtMaVT.Focus();
        }
    }
}