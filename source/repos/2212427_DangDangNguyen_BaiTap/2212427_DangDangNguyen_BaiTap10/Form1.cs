using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_BaiTap10
{
    public partial class ckbMauNen : Form
    {
        public ckbMauNen()
        {
            InitializeComponent();
        }

        private void bntButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
                this.bntButton.BackColor = Color.LightCyan;
            else
                this.bntButton.BackColor=this.bntButtonFlat.BackColor;
        }
        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauChu.Checked)
                this.bntButton.ForeColor = Color.Red;
            else
                this.bntButton.ForeColor= Color.Black;
        }

        private void rbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbFlat.Checked)
                this.bntButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                this.bntButtonFlat.FlatStyle = FlatStyle.Popup;
        }

        private void rbPopup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
