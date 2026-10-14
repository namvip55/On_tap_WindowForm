using System;
using System.Windows.Forms;

namespace ItemListManager
{
    public partial class Form1 : Form
    {
        private Class1 xuLy;

        public Form1()
        {
            InitializeComponent();
            xuLy = new Class1(this);
        }
    }
}