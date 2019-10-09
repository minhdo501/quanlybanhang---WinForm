using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDatHang : Form
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQLBHDataSet1);

        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQLBHDataSet1.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseQLBHDataSet1.orders);

        }

        private void paid_dateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
