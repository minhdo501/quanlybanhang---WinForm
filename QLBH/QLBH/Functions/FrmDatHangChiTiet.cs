using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.Functions
{
    public partial class FrmDatHangChiTiet : Form
    {
        string connectionString = QLBH.Properties.Settings.Default.DatabaseQLBHConnectionString;
        public FrmDatHangChiTiet()
        {
            InitializeComponent();
        }

        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhSachDonHang()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM orders WHERE order_date BETWEEN '{0}' AND '{1}'", tuNgay, denNgay);

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
                        databaseQLBHDataSet1.orders.Clear();
                        adapter.Fill(databaseQLBHDataSet1.orders);

                        // Hiển thị dữ liệu
                        order_detailsBindingSource.DataSource = null;
                        order_detailsBindingSource.DataSource = databaseQLBHDataSet1.orders;
                        dgvDonHang.Refresh();

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


        /// <summary>
        /// Hàm dùng để load danh sách nhân viên
        /// </summary>
        public void LoadDanhSachNhanVien()
        {
            // Tạo SortedDictionary<int, string> để tiện quản lý DataSource cho Combobox
            SortedDictionary<int, string> listEmployees = new SortedDictionary<int, string>();

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM employees");

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
                        adapter.Fill(databaseQLBHDataSet1.employees);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in databaseQLBHDataSet1.employees.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listEmployees.Add(key, value);
                        }
                        cbbEmployees.DataSource = new BindingSource(listEmployees, null);
                        cbbEmployees.DisplayMember = "Value";
                        cbbEmployees.ValueMember = "Key";

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

        public void LoadDanhSachKhachHang()
        {
            // Tạo SortedDictionary<int, string> để tiện quản lý DataSource cho Combobox
            SortedDictionary<int, string> listCustomers = new SortedDictionary<int, string>();

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM customers");

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
                        adapter.Fill(databaseQLBHDataSet1.customers);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in databaseQLBHDataSet1.customers.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["first_name"].ToString();
                            listCustomers.Add(key, value);
                        }
                        cbbCustomers.DataSource = new BindingSource(listCustomers, null);
                        cbbCustomers.DisplayMember = "Value";
                        cbbCustomers.ValueMember = "Key";

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

        public void LoadDanhSachSanPham()
        {
            // Tạo SortedDictionary<int, string> để tiện quản lý DataSource cho Combobox
            SortedDictionary<int, string> listProducts = new SortedDictionary<int, string>();

            // Tạo câu lệnh để thực thi đến database
            string queryString = String.Format("SELECT * FROM products");

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
                        adapter.Fill(databaseQLBHDataSet1.products);

                        // Hiển thị dữ liệu
                        foreach (DataRow row in databaseQLBHDataSet1.products.Rows)
                        {
                            int key = Convert.ToInt32(row["id"]);
                            string value = row["product_name"].ToString();
                            listProducts.Add(key, value);
                        }
                        cbbProducts.DataSource = new BindingSource(listProducts, null);
                        cbbProducts.DisplayMember = "Value";
                        cbbProducts.ValueMember = "Key";

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


        private void btnLayDanhSach_Click(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }

        private void FrmDatHangChiTiet_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            LoadDanhSachKhachHang();
            LoadDanhSachSanPham();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Chuẩn bị dữ liệu
            databaseQLBHDataSet1.ReportHoaDonBanHang.Rows.Clear();
            foreach (databaseQLBHDataSet1.order_detailsRow orderDetailRow in databaseQLBHDataSet1.order_details.Rows)
            {
                var row = databaseQLBHDataSet1.ReportHoaDonBanHang.NewReportHoaDonBanHangRow();

                // Nạp thông tin Chung về Công ty lấy từ Cấu hình (config)
                // Sử dụng cú pháp LINQ: collection.Where(p => p...).FirstOrDefault() để lấy dòng dữ liệu thỏa điều kiện
                row.report_company_name = databaseQLBHDataSet1.configs.Where(p => p.key == "company.name").FirstOrDefault().value;


                // Nạp thông tin về Khách hàng (customer)

                // Nạp thông tin về Đơn hàng (order)
                row.report_ordered_date_day = order_dateDateTimePicker.Value.Day.ToString();
                row.report_ordered_date_month = order_dateDateTimePicker.Value.Month.ToString();
                row.report_ordered_date_year = order_dateDateTimePicker.Value.Year.ToString();

                // Nạp thông tin về Đơn hàng Chi tiết (order_detail)
                row.report_order_detail_product_name = orderDetailRow.product_id.ToString();

                // Add dòng dữ liệu vào DataTable
                databaseQLBHDataSet1.ReportHoaDonBanHang.AddReportHoaDonBanHangRow(row);
            }

            // Hiển thị FormReport
            FormReport frm = new FormReport();
            frm.reportViewerCommon.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Reports.ReportHoaDonDatHang.rdlc";
            frm.ReportDataSourceName = "DataSetReportOrder";
            frm.Data = databaseQLBHDataSet1.ReportHoaDonBanHang;
            frm.ShowDialog();
        }
    }
}
