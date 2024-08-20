using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_BaiTap08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            int itemselect = lbDanhSach.SelectedItems.Count - 1;
            for (int i = itemselect;i>=0;i--)
            {
                lblDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
            }
        }
        private void bntRemove_Click(object sender, EventArgs e)
        {
            int i = lblDanhSachChon.SelectedItems.Count - 1;
            while (i>=0)
            {
                lblDanhSachChon.Items.RemoveAt(lblDanhSachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
