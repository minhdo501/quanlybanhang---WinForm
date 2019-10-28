namespace QLBH.Functions
{
    partial class FrmDatHangChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label lblFromDate;
            System.Windows.Forms.Label lblToDate;
            this.grpThongTinChiTietDonHang = new System.Windows.Forms.GroupBox();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseQLBHDataSet1 = new QLBH.DatabaseQLBHDataSet1();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.grpThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.cbbCustomers = new System.Windows.Forms.ComboBox();
            this.cbbEmployees = new System.Windows.Forms.ComboBox();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLayDanhSach = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.nudShipping_fee = new System.Windows.Forms.NumericUpDown();
            discountLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            lblFromDate = new System.Windows.Forms.Label();
            lblToDate = new System.Windows.Forms.Label();
            this.grpThongTinChiTietDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.grpThongTinDonHang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).BeginInit();
            this.SuspendLayout();
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(654, 22);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(50, 13);
            discountLabel.TabIndex = 35;
            discountLabel.Text = "discount:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(432, 22);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(53, 13);
            unit_priceLabel.TabIndex = 34;
            unit_priceLabel.Text = "unit price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(235, 22);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 33;
            quantityLabel.Text = "quantity:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(12, 22);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(57, 13);
            product_idLabel.TabIndex = 32;
            product_idLabel.Text = "product id:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(581, 76);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(65, 13);
            order_statusLabel.TabIndex = 31;
            order_statusLabel.Text = "order status:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(581, 50);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(54, 13);
            paid_dateLabel.TabIndex = 29;
            paid_dateLabel.Text = "paid date:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(581, 24);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(73, 13);
            payment_typeLabel.TabIndex = 27;
            payment_typeLabel.Text = "payment type:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(340, 154);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(67, 13);
            shipping_feeLabel.TabIndex = 25;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(340, 128);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(67, 13);
            ship_countryLabel.TabIndex = 23;
            ship_countryLabel.Text = "ship country:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(340, 102);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(87, 13);
            ship_postal_codeLabel.TabIndex = 21;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(340, 76);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(55, 13);
            ship_stateLabel.TabIndex = 19;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(340, 50);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(48, 13);
            ship_cityLabel.TabIndex = 17;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(340, 24);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(75, 13);
            ship_address2Label.TabIndex = 15;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(10, 155);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(75, 13);
            ship_address1Label.TabIndex = 13;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(10, 129);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(58, 13);
            ship_nameLabel.TabIndex = 11;
            ship_nameLabel.Text = "ship name:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(10, 101);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(71, 13);
            shipped_dateLabel.TabIndex = 9;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(10, 76);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(58, 13);
            order_dateLabel.TabIndex = 7;
            order_dateLabel.Text = "order date:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(10, 50);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 5;
            customer_idLabel.Text = "customer id:";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(10, 24);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(66, 13);
            employee_idLabel.TabIndex = 3;
            employee_idLabel.Text = "employee id:";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new System.Drawing.Point(4, 27);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new System.Drawing.Size(57, 13);
            lblFromDate.TabIndex = 36;
            lblFromDate.Text = "From date:";
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new System.Drawing.Point(4, 49);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new System.Drawing.Size(47, 13);
            lblToDate.TabIndex = 37;
            lblToDate.Text = "To date:";
            // 
            // grpThongTinChiTietDonHang
            // 
            this.grpThongTinChiTietDonHang.Controls.Add(this.cbbProducts);
            this.grpThongTinChiTietDonHang.Controls.Add(this.dgvChiTietDonHang);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudSoLuong);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudDonGia);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudGiamGia);
            this.grpThongTinChiTietDonHang.Controls.Add(this.btnThemChiTiet);
            this.grpThongTinChiTietDonHang.Controls.Add(discountLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(unit_priceLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(quantityLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(product_idLabel);
            this.grpThongTinChiTietDonHang.Location = new System.Drawing.Point(287, 219);
            this.grpThongTinChiTietDonHang.Name = "grpThongTinChiTietDonHang";
            this.grpThongTinChiTietDonHang.Size = new System.Drawing.Size(961, 260);
            this.grpThongTinChiTietDonHang.TabIndex = 36;
            this.grpThongTinChiTietDonHang.TabStop = false;
            this.grpThongTinChiTietDonHang.Text = "Thông tin chi tiết đơn hàng";
            // 
            // cbbProducts
            // 
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(75, 19);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(121, 21);
            this.cbbProducts.TabIndex = 35;
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AutoGenerateColumns = false;
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvChiTietDonHang.DataSource = this.order_detailsBindingSource;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(15, 58);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(937, 192);
            this.dgvChiTietDonHang.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn6.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn7.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.databaseQLBHDataSet1;
            // 
            // databaseQLBHDataSet1
            // 
            this.databaseQLBHDataSet1.DataSetName = "DatabaseQLBHDataSet1";
            this.databaseQLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1165, 485);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(287, 20);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 20);
            this.nudSoLuong.TabIndex = 39;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(491, 20);
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(120, 20);
            this.nudDonGia.TabIndex = 39;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(760, 485);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnInHoaDon.TabIndex = 38;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(710, 20);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(120, 20);
            this.nudGiamGia.TabIndex = 33;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(841, 485);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(922, 485);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1003, 485);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(843, 17);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(109, 23);
            this.btnThemChiTiet.TabIndex = 37;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // grpThongTinDonHang
            // 
            this.grpThongTinDonHang.Controls.Add(this.nudShipping_fee);
            this.grpThongTinDonHang.Controls.Add(this.cbbCustomers);
            this.grpThongTinDonHang.Controls.Add(this.cbbEmployees);
            this.grpThongTinDonHang.Controls.Add(order_statusLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_statusTextBox);
            this.grpThongTinDonHang.Controls.Add(paid_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.paid_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(this.order_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(this.shipped_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(payment_typeLabel);
            this.grpThongTinDonHang.Controls.Add(this.payment_typeTextBox);
            this.grpThongTinDonHang.Controls.Add(shipping_feeLabel);
            this.grpThongTinDonHang.Controls.Add(ship_countryLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_countryTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_postal_codeLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_postal_codeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_stateLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_stateTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_cityLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_cityTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address2Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address2TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address1Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address1TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_nameLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_nameTextBox);
            this.grpThongTinDonHang.Controls.Add(shipped_dateLabel);
            this.grpThongTinDonHang.Controls.Add(order_dateLabel);
            this.grpThongTinDonHang.Controls.Add(customer_idLabel);
            this.grpThongTinDonHang.Controls.Add(employee_idLabel);
            this.grpThongTinDonHang.Location = new System.Drawing.Point(287, 28);
            this.grpThongTinDonHang.Name = "grpThongTinDonHang";
            this.grpThongTinDonHang.Size = new System.Drawing.Size(902, 185);
            this.grpThongTinDonHang.TabIndex = 35;
            this.grpThongTinDonHang.TabStop = false;
            this.grpThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // cbbCustomers
            // 
            this.cbbCustomers.FormattingEnabled = true;
            this.cbbCustomers.Location = new System.Drawing.Point(87, 47);
            this.cbbCustomers.Name = "cbbCustomers";
            this.cbbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomers.TabIndex = 34;
            // 
            // cbbEmployees
            // 
            this.cbbEmployees.FormattingEnabled = true;
            this.cbbEmployees.Location = new System.Drawing.Point(87, 21);
            this.cbbEmployees.Name = "cbbEmployees";
            this.cbbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cbbEmployees.TabIndex = 33;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.Location = new System.Drawing.Point(660, 73);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_statusTextBox.TabIndex = 32;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(660, 47);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.paid_dateDateTimePicker.TabIndex = 30;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(87, 73);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.order_dateDateTimePicker.TabIndex = 8;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(87, 99);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shipped_dateDateTimePicker.TabIndex = 10;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.Location = new System.Drawing.Point(660, 21);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.payment_typeTextBox.TabIndex = 28;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.Location = new System.Drawing.Point(433, 125);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_countryTextBox.TabIndex = 24;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(433, 99);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_postal_codeTextBox.TabIndex = 22;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.Location = new System.Drawing.Point(433, 73);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_stateTextBox.TabIndex = 20;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.Location = new System.Drawing.Point(433, 47);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_cityTextBox.TabIndex = 18;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.Location = new System.Drawing.Point(433, 21);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address2TextBox.TabIndex = 16;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.Location = new System.Drawing.Point(87, 152);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_address1TextBox.TabIndex = 14;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.Location = new System.Drawing.Point(87, 126);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_nameTextBox.TabIndex = 12;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(67, 47);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 10;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(67, 21);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDonHang);
            this.groupBox3.Controls.Add(this.btnLayDanhSach);
            this.groupBox3.Controls.Add(lblToDate);
            this.groupBox3.Controls.Add(lblFromDate);
            this.groupBox3.Controls.Add(this.dtpTuNgay);
            this.groupBox3.Controls.Add(this.dtpDenNgay);
            this.groupBox3.Location = new System.Drawing.Point(6, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 483);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách đơn hàng";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvDonHang.DataSource = this.ordersBindingSource;
            this.dgvDonHang.Location = new System.Drawing.Point(7, 116);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(260, 324);
            this.dgvDonHang.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn11.HeaderText = "order_date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "shipped_date";
            this.dataGridViewTextBoxColumn12.HeaderText = "shipped_date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.databaseQLBHDataSet1;
            // 
            // btnLayDanhSach
            // 
            this.btnLayDanhSach.Location = new System.Drawing.Point(7, 75);
            this.btnLayDanhSach.Name = "btnLayDanhSach";
            this.btnLayDanhSach.Size = new System.Drawing.Size(261, 23);
            this.btnLayDanhSach.TabIndex = 39;
            this.btnLayDanhSach.Text = "Lấy danh sách đơn hàng";
            this.btnLayDanhSach.UseVisualStyleBackColor = true;
            this.btnLayDanhSach.Click += new System.EventHandler(this.btnLayDanhSach_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1084, 485);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // nudShipping_fee
            // 
            this.nudShipping_fee.Location = new System.Drawing.Point(433, 152);
            this.nudShipping_fee.Name = "nudShipping_fee";
            this.nudShipping_fee.Size = new System.Drawing.Size(100, 20);
            this.nudShipping_fee.TabIndex = 40;
            // 
            // FrmDatHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpThongTinChiTietDonHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpThongTinDonHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "FrmDatHangChiTiet";
            this.Text = "FrmDatHangChiTiet";
            this.Load += new System.EventHandler(this.FrmDatHangChiTiet_Load);
            this.grpThongTinChiTietDonHang.ResumeLayout(false);
            this.grpThongTinChiTietDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseQLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.grpThongTinDonHang.ResumeLayout(false);
            this.grpThongTinDonHang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinChiTietDonHang;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.GroupBox grpThongTinDonHang;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private DatabaseQLBHDataSet1 databaseQLBHDataSet1;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnLayDanhSach;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.ComboBox cbbEmployees;
        private System.Windows.Forms.ComboBox cbbCustomers;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.NumericUpDown nudShipping_fee;
    }
}