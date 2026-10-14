namespace ITSupportApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Bố cục Nhóm (GroupBox)
        public System.Windows.Forms.GroupBox grpThongTin;
        public System.Windows.Forms.GroupBox grpPhanLoai;

        // Tiêu đề
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Khai báo public các Control để Class1 sử dụng
        public System.Windows.Forms.TextBox txtMaPhieu;
        public System.Windows.Forms.TextBox txtNguoiYeuCau;
        public System.Windows.Forms.DateTimePicker dtpNgay;
        public System.Windows.Forms.RadioButton rbThap;
        public System.Windows.Forms.RadioButton rbTrungBinh;
        public System.Windows.Forms.RadioButton rbKhanCap;
        public System.Windows.Forms.ComboBox cboLoaiSuCo;
        public System.Windows.Forms.CheckBox cbMayBan;
        public System.Windows.Forms.CheckBox cbLaptop;
        public System.Windows.Forms.CheckBox cbMayIn;
        public System.Windows.Forms.CheckBox cbDienThoai;
        public System.Windows.Forms.PictureBox picAnh;
        public System.Windows.Forms.Button btnTaiAnh;
        public System.Windows.Forms.Button btnGui;
        public System.Windows.Forms.Button btnNhapLai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpPhanLoai = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.rbThap = new System.Windows.Forms.RadioButton();
            this.rbTrungBinh = new System.Windows.Forms.RadioButton();
            this.rbKhanCap = new System.Windows.Forms.RadioButton();
            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.cbMayBan = new System.Windows.Forms.CheckBox();
            this.cbLaptop = new System.Windows.Forms.CheckBox();
            this.cbMayIn = new System.Windows.Forms.CheckBox();
            this.cbDienThoai = new System.Windows.Forms.CheckBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.grpPhanLoai.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "IT Support Ticket Form";
            this.ClientSize = new System.Drawing.Size(760, 680);
            this.MinimumSize = new System.Drawing.Size(780, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.AutoScroll = true;

            // 
            // Header
            // 
            this.lblTitle.Text = "TIẾP NHẬN SỰ CỐ IT";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.SetBounds(0, 15, 760, 32);

            this.lblSubtitle.Text = "Vui lòng nhập thông tin để tạo phiếu hỗ trợ IT";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitle.SetBounds(0, 48, 760, 22);

            // 
            // GroupBox 1: THÔNG TIN PHIẾU
            // 
            this.grpThongTin.Text = "THÔNG TIN PHIẾU";
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.grpThongTin.SetBounds(25, 80, 710, 205);

            ThemLabel(this.grpThongTin, "Mã phiếu:", 20, 32, 120, 25);
            this.txtMaPhieu.SetBounds(150, 29, 530, 27);
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMaPhieu.Text = "IT001";

            ThemLabel(this.grpThongTin, "Người yêu cầu:", 20, 72, 120, 25);
            this.txtNguoiYeuCau.SetBounds(150, 69, 530, 27);
            this.txtNguoiYeuCau.Font = new System.Drawing.Font("Segoe UI", 9.75F);

            ThemLabel(this.grpThongTin, "Ngày ghi nhận:", 20, 112, 120, 25);
            this.dtpNgay.SetBounds(150, 109, 530, 27);
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";

            ThemLabel(this.grpThongTin, "Mức độ ưu tiên:", 20, 152, 120, 25);

            this.rbThap.Text = "Thấp";
            this.rbThap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbThap.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbThap.SetBounds(150, 152, 90, 25);
            this.rbThap.Checked = true;

            this.rbTrungBinh.Text = "Trung bình";
            this.rbTrungBinh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbTrungBinh.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbTrungBinh.SetBounds(260, 152, 110, 25);

            this.rbKhanCap.Text = "Khẩn cấp";
            this.rbKhanCap.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbKhanCap.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.rbKhanCap.SetBounds(390, 152, 110, 25);

            this.grpThongTin.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.txtMaPhieu, this.txtNguoiYeuCau, this.dtpNgay,
                this.rbThap, this.rbTrungBinh, this.rbKhanCap
            });

            // 
            // GroupBox 2: PHÂN LOẠI & CHI TIẾT
            // 
            this.grpPhanLoai.Text = "PHÂN LOẠI & CHI TIẾT";
            this.grpPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpPhanLoai.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            this.grpPhanLoai.SetBounds(25, 295, 710, 300);

            ThemLabel(this.grpPhanLoai, "Loại sự cố:", 20, 32, 120, 25);
            this.cboLoaiSuCo.SetBounds(150, 29, 530, 27);
            this.cboLoaiSuCo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSuCo.Items.AddRange(new object[]
            {
                "Phần cứng", "Phần mềm", "Mạng", "Tài khoản"
            });
            this.cboLoaiSuCo.SelectedIndex = 0;

            ThemLabel(this.grpPhanLoai, "Thiết bị ảnh hưởng:", 20, 72, 120, 25);

            this.cbMayBan.Text = "Máy tính bàn";
            this.cbMayBan.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbMayBan.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbMayBan.SetBounds(150, 72, 120, 25);

            this.cbLaptop.Text = "Laptop";
            this.cbLaptop.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbLaptop.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbLaptop.SetBounds(280, 72, 90, 25);

            this.cbMayIn.Text = "Máy in";
            this.cbMayIn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbMayIn.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbMayIn.SetBounds(390, 72, 90, 25);

            this.cbDienThoai.Text = "Điện thoại";
            this.cbDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDienThoai.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cbDienThoai.SetBounds(500, 72, 110, 25);

            ThemLabel(this.grpPhanLoai, "Ảnh chụp lỗi:", 20, 115, 120, 25);

            this.picAnh.SetBounds(150, 115, 240, 160);
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.BackColor = System.Drawing.Color.White;

            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.SetBounds(410, 115, 130, 36);
            this.btnTaiAnh.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnTaiAnh.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnTaiAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnh.FlatAppearance.BorderSize = 0;
            this.btnTaiAnh.Cursor = System.Windows.Forms.Cursors.Hand;

            this.grpPhanLoai.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.cboLoaiSuCo, this.cbMayBan, this.cbLaptop, this.cbMayIn,
                this.cbDienThoai, this.picAnh, this.btnTaiAnh
            });

            // 
            // Nút Chức năng
            // 
            this.btnGui.Text = "Gửi yêu cầu";
            this.btnGui.SetBounds(220, 610, 160, 42);
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGui.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.FlatAppearance.BorderSize = 0;
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.SetBounds(395, 610, 140, 42);
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnNhapLai.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;

            // Thêm các thành phần chính vào Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpPhanLoai);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnNhapLai);

            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpPhanLoai.ResumeLayout(false);
            this.grpPhanLoai.PerformLayout();
            this.ResumeLayout(false);
        }

        private void ThemLabel(System.Windows.Forms.Control parent, string text, int x, int y, int width, int height)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = text;
            lbl.SetBounds(x, y, width, height);
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            lbl.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            parent.Controls.Add(lbl);
        }
    }
}