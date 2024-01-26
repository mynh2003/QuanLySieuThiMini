namespace WindowsFormsApp1.UserControls
{
    partial class ucPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.gbNhap = new System.Windows.Forms.GroupBox();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.dataCT = new System.Windows.Forms.DataGridView();
            this.sothutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoaHetCT = new System.Windows.Forms.Button();
            this.lblCongNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(623, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phieu Nhap";
            // 
            // gbNhap
            // 
            this.gbNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbNhap.Controls.Add(this.cbMaNCC);
            this.gbNhap.Controls.Add(this.cbMaNV);
            this.gbNhap.Controls.Add(this.lblNgayNhap);
            this.gbNhap.Controls.Add(this.label9);
            this.gbNhap.Controls.Add(this.label10);
            this.gbNhap.Controls.Add(this.label3);
            this.gbNhap.Controls.Add(this.label2);
            this.gbNhap.Controls.Add(this.tbMaPN);
            this.gbNhap.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNhap.Location = new System.Drawing.Point(14, 51);
            this.gbNhap.Name = "gbNhap";
            this.gbNhap.Size = new System.Drawing.Size(1187, 127);
            this.gbNhap.TabIndex = 1;
            this.gbNhap.TabStop = false;
            this.gbNhap.Text = "Thong tin phieu nhap";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNCC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(404, 50);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(160, 27);
            this.cbMaNCC.TabIndex = 20;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(727, 50);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(160, 27);
            this.cbMaNV.TabIndex = 19;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(1039, 54);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(86, 18);
            this.lblNgayNhap.TabIndex = 18;
            this.lblNgayNhap.Text = "03/08/2003";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(943, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngay Nhap:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(620, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ma NV Nhan:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma NCC:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma PN:";
            // 
            // tbMaPN
            // 
            this.tbMaPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaPN.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaPN.Location = new System.Drawing.Point(111, 50);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(160, 26);
            this.tbMaPN.TabIndex = 0;
            this.tbMaPN.TextChanged += new System.EventHandler(this.tbMaPN_TextChanged_1);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOK.Enabled = false;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(917, 594);
            this.btnOK.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 40);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "       OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.EnabledChanged += new System.EventHandler(this.btnOK_EnabledChanged);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chi tiet phieu nhap";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tong Tien:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(122, 581);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 23);
            this.lblTongTien.TabIndex = 19;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnThem.Enabled = false;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(761, 594);
            this.btnThem.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 40);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "       Them";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.EnabledChanged += new System.EventHandler(this.btnThem_EnabledChanged);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(1229, 594);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 40);
            this.btnHuy.TabIndex = 44;
            this.btnHuy.Text = "       Huy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.EnabledChanged += new System.EventHandler(this.btnHuy_EnabledChanged);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(1229, 61);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(132, 40);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "       Nhap";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.EnabledChanged += new System.EventHandler(this.btnNhap_EnabledChanged);
            this.btnNhap.Click += new System.EventHandler(this.btnNhapPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPhieu.BackColor = System.Drawing.Color.Red;
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieu.Image")));
            this.btnXoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.Location = new System.Drawing.Point(1229, 127);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(132, 40);
            this.btnXoaPhieu.TabIndex = 30;
            this.btnXoaPhieu.Text = "       Xoa het";
            this.btnXoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.EnabledChanged += new System.EventHandler(this.btnXoaPhieu_EnabledChanged);
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // dataCT
            // 
            this.dataCT.AllowUserToAddRows = false;
            this.dataCT.AllowUserToDeleteRows = false;
            this.dataCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sothutu,
            this.ma_hh,
            this.ten_hh,
            this.so_luong,
            this.DonViTinh,
            this.gia_nhap,
            this.thanh_tien,
            this.btn_sua,
            this.btn_xoa});
            this.dataCT.Location = new System.Drawing.Point(14, 224);
            this.dataCT.Name = "dataCT";
            this.dataCT.ReadOnly = true;
            this.dataCT.RowHeadersWidth = 51;
            this.dataCT.RowTemplate.Height = 24;
            this.dataCT.Size = new System.Drawing.Size(1347, 354);
            this.dataCT.TabIndex = 45;
            this.dataCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCT_CellContentClick_1);
            // 
            // sothutu
            // 
            this.sothutu.HeaderText = "STT";
            this.sothutu.MinimumWidth = 6;
            this.sothutu.Name = "sothutu";
            this.sothutu.ReadOnly = true;
            // 
            // ma_hh
            // 
            this.ma_hh.HeaderText = "Mã hàng hóa";
            this.ma_hh.MinimumWidth = 6;
            this.ma_hh.Name = "ma_hh";
            this.ma_hh.ReadOnly = true;
            // 
            // ten_hh
            // 
            this.ten_hh.HeaderText = "Tên hàng hóa";
            this.ten_hh.MinimumWidth = 6;
            this.ten_hh.Name = "ten_hh";
            this.ten_hh.ReadOnly = true;
            // 
            // so_luong
            // 
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 6;
            this.so_luong.Name = "so_luong";
            this.so_luong.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // gia_nhap
            // 
            this.gia_nhap.HeaderText = "Giá nhập";
            this.gia_nhap.MinimumWidth = 6;
            this.gia_nhap.Name = "gia_nhap";
            this.gia_nhap.ReadOnly = true;
            // 
            // thanh_tien
            // 
            this.thanh_tien.HeaderText = "Thành tiền";
            this.thanh_tien.MinimumWidth = 6;
            this.thanh_tien.Name = "thanh_tien";
            this.thanh_tien.ReadOnly = true;
            // 
            // btn_sua
            // 
            this.btn_sua.HeaderText = "Sửa";
            this.btn_sua.MinimumWidth = 6;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ReadOnly = true;
            this.btn_sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_xoa
            // 
            this.btn_xoa.HeaderText = "Xóa";
            this.btn_xoa.MinimumWidth = 6;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ReadOnly = true;
            this.btn_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnXoaHetCT
            // 
            this.btnXoaHetCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHetCT.BackColor = System.Drawing.Color.Red;
            this.btnXoaHetCT.Enabled = false;
            this.btnXoaHetCT.FlatAppearance.BorderSize = 0;
            this.btnXoaHetCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHetCT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHetCT.ForeColor = System.Drawing.Color.White;
            this.btnXoaHetCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHetCT.Image")));
            this.btnXoaHetCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHetCT.Location = new System.Drawing.Point(1073, 594);
            this.btnXoaHetCT.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnXoaHetCT.Name = "btnXoaHetCT";
            this.btnXoaHetCT.Size = new System.Drawing.Size(132, 40);
            this.btnXoaHetCT.TabIndex = 46;
            this.btnXoaHetCT.Text = "       Xoa het";
            this.btnXoaHetCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHetCT.UseVisualStyleBackColor = false;
            this.btnXoaHetCT.EnabledChanged += new System.EventHandler(this.btnXoaHetCT_EnabledChanged);
            this.btnXoaHetCT.Click += new System.EventHandler(this.btnXoaHetCT_Click);
            // 
            // lblCongNo
            // 
            this.lblCongNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCongNo.AutoSize = true;
            this.lblCongNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongNo.Location = new System.Drawing.Point(122, 611);
            this.lblCongNo.Name = "lblCongNo";
            this.lblCongNo.Size = new System.Drawing.Size(71, 23);
            this.lblCongNo.TabIndex = 48;
            this.lblCongNo.Text = "0 VNĐ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cong No:";
            // 
            // ucPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCongNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaHetCT);
            this.Controls.Add(this.dataCT);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucPhieuNhap";
            this.Size = new System.Drawing.Size(1375, 648);
            this.Load += new System.EventHandler(this.ucPhieuNhap_Load);
            this.gbNhap.ResumeLayout(false);
            this.gbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNhap;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.DataGridView dataCT;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.Button btnXoaHetCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothutu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanh_tien;
        private System.Windows.Forms.DataGridViewButtonColumn btn_sua;
        private System.Windows.Forms.DataGridViewButtonColumn btn_xoa;
        private System.Windows.Forms.Label lblCongNo;
        private System.Windows.Forms.Label label5;
    }
}
