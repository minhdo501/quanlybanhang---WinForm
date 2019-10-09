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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPass.Text == "12345")
            {
                MessageBox.Show("Dang nhap thanh cong");
                this.Hide();

                FrmMain frmmain = new FrmMain();
                frmmain.Show();
            } else
            {
                MessageBox.Show("Dang nhap khong thanh cong, vui long kiem tra lai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
