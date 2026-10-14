using System;
using System.Windows.Forms;

namespace ITSupportApp
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