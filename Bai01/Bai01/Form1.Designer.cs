namespace Bai1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuongKhach;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuongKhach;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnLamMoi;

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
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongKhach = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(30, 30);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(95, 15);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá dịch vụ:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(180, 27);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(200, 23);
            this.txtDonGia.TabIndex = 0;
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.Location = new System.Drawing.Point(30, 75);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(92, 15);
            this.lblSoLuongKhach.TabIndex = 7;
            this.lblSoLuongKhach.Text = "Số lượng khách:";
            // 
            // txtSoLuongKhach
            // 
            this.txtSoLuongKhach.Location = new System.Drawing.Point(180, 72);
            this.txtSoLuongKhach.Name = "txtSoLuongKhach";
            this.txtSoLuongKhach.Size = new System.Drawing.Size(200, 23);
            this.txtSoLuongKhach.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(30, 120);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(78, 15);
            this.lblGiamGia.TabIndex = 6;
            this.lblGiamGia.Text = "Giảm giá (%):";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(180, 117);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(200, 23);
            this.txtGiamGia.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongTien.Location = new System.Drawing.Point(30, 165);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(205, 19);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(80, 210);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(120, 35);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(220, 210);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 35);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTinhTien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 270);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblSoLuongKhach);
            this.Controls.Add(this.txtSoLuongKhach);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy tính cước dịch vụ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}