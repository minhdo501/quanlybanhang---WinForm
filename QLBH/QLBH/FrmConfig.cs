using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FrmConfig : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QLBH.Properties.Settings.Default.DatabaseQLBHConnectionString;

        public FrmConfig()
        {
            InitializeComponent();
        }

        private void ConfigsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseQLBHDataSet1);

        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseQLBHDataSet1.configs' table. You can move, or remove it, as needed.
            this.configsTableAdapter.Fill(this.databaseQLBHDataSet1.configs);

        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhMucCauHinh()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM configs";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(databaseQLBHDataSet1.configs);

                        // Hiển thị dữ liệu
                        configsBindingSource.DataSource = null;
                        configsBindingSource.DataSource = databaseQLBHDataSet1.configs;
                        configsDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmConfig frmconfig = new FrmConfig();
            
        }
    }
}
