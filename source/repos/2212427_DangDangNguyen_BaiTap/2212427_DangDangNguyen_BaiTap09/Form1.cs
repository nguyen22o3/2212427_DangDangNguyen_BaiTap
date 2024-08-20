using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbNữ.Checked)
            {
                MessageBox.Show("Giới tính của bạn là: "+rbNữ.Text);
            }
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbNam.Checked)
            {
                MessageBox.Show("Giới tính của bạn là: "+rbNam.Text);
            }
        }
    }
}
