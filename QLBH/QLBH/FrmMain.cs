using QLBH.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucKhachHang frmDMKH = new FrmDanhMucKhachHang();
            frmDMKH.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien frmDMNV = new FrmDanhMucNhanVien();
            frmDMNV.Show();
        }

        private void CấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfig frmconfig = new FrmConfig();
            frmconfig.Show();
        }
    }
}
