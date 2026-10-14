namespace ItemListManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.GroupBox grpNhapLieu;
        public System.Windows.Forms.GroupBox grpDanhSach;

        public System.Windows.Forms.TextBox txtMaVT;
        public System.Windows.Forms.TextBox txtTenVT;
        public System.Windows.Forms.ComboBox cboDVT;
        public System.Windows.Forms.TextBox txtDonGia;

        public System.Windows.Forms.ListView lsvVatTu;
        public System.Windows.Forms.ColumnHeader colMaVT;
        public System.Windows.Forms.ColumnHeader colTenVT;
        public System.Windows.Forms.ColumnHeader colDVT;
        public System.Windows.Forms.ColumnHeader colDonGia;

        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnCapNhat;
        public System.Windows.Forms.Button btnXoaDong;
        public System.Windows.Forms.Button btnXoaToanBo;
        public System.Windows.Forms.Button btnLamMoi; // Nút tiện ích mở rộng

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
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lsvVatTu = new System.Windows.Forms.ListView();
            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDVT = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();
            
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.Text = "Quản lý Danh mục Vật tư / Linh kiện";
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);

            // Tiêu đề
            System.Windows.Forms.Label lblTitle = new System.Windows.Forms.Label();
            lblTitle.Text = "QUẢN LÝ DANH MỤC VẬT TƯ / LINH KIỆN";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.SetBounds(0, 20, 950, 40);
            this.Controls.Add(lblTitle);

            // 
            // grpNhapLieu (Nhóm Trái)
            // 
            this.grpNhapLieu.Text = "Thông tin Nhập liệu";
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpNhapLieu.SetBounds(20, 80, 320, 450);
            this.Controls.Add(this.grpNhapLieu);

            ThemLabel(this.grpNhapLieu, "Mã vật tư:", 20, 40, 100, 25);
            this.txtMaVT.SetBounds(120, 37, 180, 27);
            this.txtMaVT.Font = new System.Drawing.Font("Segoe UI", 9.75F);

            ThemLabel(this.grpNhapLieu, "Tên vật tư:", 20, 90, 100, 25);
            this.txtTenVT.SetBounds(120, 87, 180, 27);
            this.txtTenVT.Font = new System.Drawing.Font("Segoe UI", 9.75F);

            ThemLabel(this.grpNhapLieu, "Đơn vị tính:", 20, 140, 100, 25);
            this.cboDVT.SetBounds(120, 137, 180, 27);
            this.cboDVT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVT.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.cboDVT.SelectedIndex = 0;

            ThemLabel(this.grpNhapLieu, "Đơn giá nhập:", 20, 190, 100, 25);
            this.txtDonGia.SetBounds(120, 187, 180, 27);
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F);

            // Cấu hình Nút bấm
            this.btnThem.Text = "Thêm mới";
            this.btnThem.SetBounds(20, 260, 135, 40);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(16, 185, 129); // Xanh lá
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.SetBounds(165, 260, 135, 40);
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(59, 130, 246); // Xanh dương
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.SetBounds(20, 310, 135, 40);
            this.btnXoaDong.BackColor = System.Drawing.Color.FromArgb(239, 68, 68); // Đỏ
            this.btnXoaDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDong.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.SetBounds(165, 310, 135, 40);
            this.btnXoaToanBo.BackColor = System.Drawing.Color.FromArgb(220, 38, 38); // Đỏ đậm
            this.btnXoaToanBo.ForeColor = System.Drawing.Color.White;
            this.btnXoaToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaToanBo.Cursor = System.Windows.Forms.Cursors.Hand;
            
            this.btnLamMoi.Text = "Bỏ chọn / Nhập mới";
            this.btnLamMoi.SetBounds(20, 380, 280, 40);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(226, 232, 240); // Xám bạc
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;

            this.grpNhapLieu.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                this.txtMaVT, this.txtTenVT, this.cboDVT, this.txtDonGia,
                this.btnThem, this.btnCapNhat, this.btnXoaDong, this.btnXoaToanBo, this.btnLamMoi
            });

            // 
            // grpDanhSach (Nhóm Phải)
            // 
            this.grpDanhSach.Text = "Danh sách Vật tư";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.SetBounds(360, 80, 560, 450);
            this.Controls.Add(this.grpDanhSach);

            // ListView
            this.lsvVatTu.SetBounds(20, 35, 520, 395);
            this.lsvVatTu.View = System.Windows.Forms.View.Details;
            this.lsvVatTu.FullRowSelect = true;
            this.lsvVatTu.GridLines = true;
            this.lsvVatTu.Font = new System.Drawing.Font("Segoe UI", 9.75F);

            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 80;

            this.colTenVT.Text = "Tên Vật tư";
            this.colTenVT.Width = 220;

            this.colDVT.Text = "Đơn vị tính";
            this.colDVT.Width = 100;

            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 110;

            this.lsvVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] 
            { 
                this.colMaVT, this.colTenVT, this.colDVT, this.colDonGia 
            });

            this.grpDanhSach.Controls.Add(this.lsvVatTu);

            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void ThemLabel(System.Windows.Forms.Control parent, string text, int x, int y, int width, int height)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = text;
            lbl.SetBounds(x, y, width, height);
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            parent.Controls.Add(lbl);
        }
    }
}