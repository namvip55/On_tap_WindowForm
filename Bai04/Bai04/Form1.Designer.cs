
namespace WinFormsApp1
{
    partial class Form1
    {
        public System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.TableLayoutPanel slotPanel;
        public System.Windows.Forms.ComboBox cboTime;
        public System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Button btnConfirm;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblBooked;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel bottomPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            slotPanel = new TableLayoutPanel();
            cboTime = new ComboBox();
            lblCount = new Label();
            lblTotal = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            lblTime = new Label();
            lblEmpty = new Label();
            lblSelected = new Label();
            lblBooked = new Label();
            mainPanel = new TableLayoutPanel();
            timePanel = new FlowLayoutPanel();
            bottomPanel = new FlowLayoutPanel();
            summaryPanel = new TableLayoutPanel();
            mainPanel.SuspendLayout();
            timePanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // slotPanel
            // 
            slotPanel.BackColor = Color.White;
            slotPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            slotPanel.Dock = DockStyle.Fill;
            slotPanel.Location = new Point(24, 169);
            slotPanel.Margin = new Padding(0, 5, 0, 5);
            slotPanel.Name = "slotPanel";
            slotPanel.Size = new Size(802, 327);
            slotPanel.TabIndex = 2;
            // 
            // cboTime
            // 
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.Font = new Font("Segoe UI", 11F);
            cboTime.Location = new Point(158, 20);
            cboTime.Margin = new Padding(0, 5, 0, 0);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(230, 48);
            cboTime.TabIndex = 1;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCount.Location = new Point(0, 8);
            lblCount.Margin = new Padding(0, 8, 0, 8);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(316, 36);
            lblCount.TabIndex = 0;
            lblCount.Text = "Số vị trí đang chọn: 0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(20, 120, 70);
            lblTotal.Location = new Point(0, 60);
            lblTotal.Margin = new Padding(0, 8, 0, 8);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(303, 36);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tạm tính tiền: 0đ";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(35, 115, 80);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(437, 5);
            btnConfirm.Margin = new Padding(0, 5, 12, 0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(170, 42);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Xác nhận đặt";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(225, 230, 237);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(40, 50, 65);
            btnCancel.Location = new Point(437, 57);
            btnCancel.Margin = new Padding(0, 5, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 42);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Hủy chọn tất cả";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 55, 90);
            lblTitle.Location = new Point(27, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(796, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐẶT CHỖ / ĐẶT BÀN";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(0, 25);
            lblTime.Margin = new Padding(0, 10, 12, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(146, 37);
            lblTime.TabIndex = 0;
            lblTime.Text = "Khung giờ:";
            // 
            // lblEmpty
            // 
            lblEmpty.AutoSize = true;
            lblEmpty.BackColor = Color.WhiteSmoke;
            lblEmpty.Location = new Point(3, 5);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Padding = new Padding(10, 5, 10, 5);
            lblEmpty.Size = new Size(105, 47);
            lblEmpty.TabIndex = 0;
            lblEmpty.Text = "Trống";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.BackColor = Color.LightGreen;
            lblSelected.Location = new Point(114, 5);
            lblSelected.Name = "lblSelected";
            lblSelected.Padding = new Padding(10, 5, 10, 5);
            lblSelected.Size = new Size(166, 47);
            lblSelected.TabIndex = 1;
            lblSelected.Text = "Đang chọn";
            // 
            // lblBooked
            // 
            lblBooked.AutoSize = true;
            lblBooked.BackColor = Color.LightCoral;
            lblBooked.Location = new Point(286, 5);
            lblBooked.Name = "lblBooked";
            lblBooked.Padding = new Padding(10, 5, 10, 5);
            lblBooked.Size = new Size(116, 47);
            lblBooked.TabIndex = 2;
            lblBooked.Text = "Đã đặt";
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 1;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainPanel.Controls.Add(lblTitle, 0, 0);
            mainPanel.Controls.Add(timePanel, 0, 1);
            mainPanel.Controls.Add(slotPanel, 0, 2);
            mainPanel.Controls.Add(bottomPanel, 0, 3);
            mainPanel.Controls.Add(summaryPanel, 0, 4);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(24);
            mainPanel.RowCount = 5;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            mainPanel.Size = new Size(850, 680);
            mainPanel.TabIndex = 0;
            // 
            // timePanel
            // 
            timePanel.Controls.Add(lblTime);
            timePanel.Controls.Add(cboTime);
            timePanel.Dock = DockStyle.Fill;
            timePanel.Location = new Point(27, 82);
            timePanel.Name = "timePanel";
            timePanel.Padding = new Padding(0, 15, 0, 10);
            timePanel.Size = new Size(796, 79);
            timePanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(lblEmpty);
            bottomPanel.Controls.Add(lblSelected);
            bottomPanel.Controls.Add(lblBooked);
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.Location = new Point(27, 504);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(0, 5, 0, 0);
            bottomPanel.Size = new Size(796, 39);
            bottomPanel.TabIndex = 3;
            // 
            // summaryPanel
            // 
            summaryPanel.ColumnCount = 2;
            summaryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            summaryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            summaryPanel.Controls.Add(lblCount, 0, 0);
            summaryPanel.Controls.Add(lblTotal, 0, 1);
            summaryPanel.Controls.Add(btnConfirm, 1, 0);
            summaryPanel.Controls.Add(btnCancel, 1, 1);
            summaryPanel.Dock = DockStyle.Fill;
            summaryPanel.Location = new Point(27, 549);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.RowCount = 2;
            summaryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            summaryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            summaryPanel.Size = new Size(796, 104);
            summaryPanel.TabIndex = 4;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(850, 680);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(750, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interactive Slot Booking";
            mainPanel.ResumeLayout(false);
            timePanel.ResumeLayout(false);
            timePanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        private FlowLayoutPanel timePanel;
        private TableLayoutPanel summaryPanel;
    }
}
