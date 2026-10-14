using System;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        private readonly TinhCuocService _tinhCuocService = new TinhCuocService();

        public Form1()
        {
            InitializeComponent();
            DangKySuKien();
        }

        private void DangKySuKien()
        {
            btnTinhTien.Click += BtnTinhTien_Click;
            btnLamMoi.Click += BtnLamMoi_Click;

            // Đăng ký sự kiện tự động bôi đen văn bản khi click/tab vào TextBox
            txtDonGia.Enter += TextBox_Enter;
            txtSoLuongKhach.Enter += TextBox_Enter;
            txtGiamGia.Enter += TextBox_Enter;
        }

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            if (!_tinhCuocService.TinhTien(txtDonGia.Text, txtSoLuongKhach.Text, txtGiamGia.Text, out decimal tongTien, out string loi))
            {
                MessageBox.Show(loi, "Cảnh báo nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblTongTien.Text = $"Tổng tiền thanh toán: {tongTien:N0} VNĐ";
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuongKhach.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";
            txtDonGia.Focus();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }
    }
}