
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Class1
    {
        private Form1 form;
        private Button[,] slots = new Button[4, 5];
        private int morningPrice = 100000;
        private int eveningPrice = 150000;
        private int selectedCount = 0;

        public Class1(Form1 form)
        {
            this.form = form;
        }

        public void Initialize()
        {
            form.slotPanel.Controls.Clear();
            form.slotPanel.RowCount = 4;
            form.slotPanel.ColumnCount = 5;
            form.slotPanel.Dock = DockStyle.Fill;
            form.slotPanel.RowStyles.Clear();
            form.slotPanel.ColumnStyles.Clear();

            for (int i = 0; i < 4; i++)
                form.slotPanel.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 25));

            for (int j = 0; j < 5; j++)
                form.slotPanel.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 20));

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Text = "Vị trí " + (i * 5 + j + 1);
                    btn.Name = "btnSlot" + (i * 5 + j + 1);
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(6);
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Silver;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.Tag = false;
                    btn.Click += Slot_Click;

                    slots[i, j] = btn;
                    form.slotPanel.Controls.Add(btn, j, i);
                }
            }

            form.cboTime.Items.Clear();
            form.cboTime.Items.Add("Sáng - 100.000đ");
            form.cboTime.Items.Add("Tối - 150.000đ");
            form.cboTime.SelectedIndex = 0;

            form.cboTime.SelectedIndexChanged += CboTime_SelectedIndexChanged;
            form.btnConfirm.Click += BtnConfirm_Click;
            form.btnCancel.Click += BtnCancel_Click;

            UpdateStatistics();
        }

        private void Slot_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null || !(btn.Tag is bool))
                return;

            if ((bool)btn.Tag)
            {
                btn.Tag = false;
                btn.BackColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Black;
            }
            else
            {
                btn.Tag = true;
                btn.BackColor = Color.LightGreen;
                btn.ForeColor = Color.DarkGreen;
            }

            UpdateStatistics();
        }

        private void CboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            selectedCount = 0;

            foreach (Button btn in slots)
            {
                if (btn != null && btn.Tag is bool && (bool)btn.Tag)
                    selectedCount++;
            }

            int price = form.cboTime.SelectedIndex == 1
                ? eveningPrice
                : morningPrice;

            form.lblCount.Text = "Số vị trí đang chọn: " + selectedCount;
            form.lblTotal.Text = "Tạm tính tiền: " +
                (selectedCount * price).ToString("N0") + "đ";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button btn in slots)
            {
                if (btn != null && btn.Tag is bool && (bool)btn.Tag)
                {
                    btn.Tag = false;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.ForeColor = Color.Black;
                }
            }

            UpdateStatistics();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            UpdateStatistics();

            if (selectedCount == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn ít nhất một vị trí.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int price = form.cboTime.SelectedIndex == 1
                ? eveningPrice
                : morningPrice;

            DialogResult result = MessageBox.Show(
                "Số vị trí: " + selectedCount +
                "\nKhung giờ: " + form.cboTime.Text +
                "\nTổng tiền: " + (selectedCount * price).ToString("N0") + "đ" +
                "\n\nXác nhận đặt vị trí?",
                "Xác nhận đặt",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            foreach (Button btn in slots)
            {
                if (btn != null && btn.Tag is bool && (bool)btn.Tag)
                {
                    btn.Tag = "Booked";
                    btn.BackColor = Color.LightCoral;
                    btn.ForeColor = Color.DarkRed;
                    btn.Enabled = false;
                }
            }

            UpdateStatistics();

            MessageBox.Show(
                "Đặt vị trí thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
