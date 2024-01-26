namespace WindowsFormsApp1.UserControls
{
    partial class ucBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnControls = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaHetCT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.gbNhap = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.dataTT = new System.Windows.Forms.DataGridView();
            this.STT_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTK_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNQ_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSX_TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCT = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.pnControls.SuspendLayout();
            this.gbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(635, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ban Hang";
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(this.lblTongTien);
            this.pnControls.Controls.Add(this.label7);
            this.pnControls.Controls.Add(this.btnXoaHetCT);
            this.pnControls.Controls.Add(this.btnHuy);
            this.pnControls.Controls.Add(this.btnThem);
            this.pnControls.Controls.Add(this.btnOK);
            this.pnControls.Controls.Add(this.label8);
            this.pnControls.Controls.Add(this.label3);
            this.pnControls.Controls.Add(this.btnXoaPhieu);
            this.pnControls.Controls.Add(this.btnNhap);
            this.pnControls.Controls.Add(this.gbNhap);
            this.pnControls.Controls.Add(this.dataTT);
            this.pnControls.Controls.Add(this.dataCT);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControls.Location = new System.Drawing.Point(0, 60);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(1375, 648);
            this.pnControls.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(126, 602);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 23);
            this.lblTongTien.TabIndex = 59;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Tong Tien:";
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
            this.btnXoaHetCT.TabIndex = 57;
            this.btnXoaHetCT.Text = "       Xoa het";
            this.btnXoaHetCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHetCT.UseVisualStyleBackColor = false;
            this.btnXoaHetCT.EnabledChanged += new System.EventHandler(this.btnXoaHetCT_EnabledChanged);
            this.btnXoaHetCT.Click += new System.EventHandler(this.btnXoaHetCT_Click);
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
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "       Huy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.EnabledChanged += new System.EventHandler(this.btnHuy_EnabledChanged);
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
            this.btnThem.TabIndex = 55;
            this.btnThem.Text = "       Them";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.EnabledChanged += new System.EventHandler(this.btnThem_EnabledChanged);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnOK.TabIndex = 54;
            this.btnOK.Text = "       OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.EnabledChanged += new System.EventHandler(this.btnOK_EnabledChanged);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(689, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "Danh Sach Hang Hoa";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Chi Tiet Hoa Don";
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.Color.Red;
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieu.Image")));
            this.btnXoaPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.Location = new System.Drawing.Point(549, 150);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(8);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(132, 45);
            this.btnXoaPhieu.TabIndex = 32;
            this.btnXoaPhieu.Text = "       Xoa het";
            this.btnXoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.EnabledChanged += new System.EventHandler(this.btnXoaPhieu_EnabledChanged);
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(401, 150);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(8);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(132, 45);
            this.btnNhap.TabIndex = 31;
            this.btnNhap.Text = "       Nhap";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.EnabledChanged += new System.EventHandler(this.btnNhap_EnabledChanged);
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // gbNhap
            // 
            this.gbNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbNhap.Controls.Add(this.cbMaNV);
            this.gbNhap.Controls.Add(this.lblNgayBan);
            this.gbNhap.Controls.Add(this.label9);
            this.gbNhap.Controls.Add(this.label10);
            this.gbNhap.Controls.Add(this.label2);
            this.gbNhap.Controls.Add(this.tbMaHD);
            this.gbNhap.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNhap.Location = new System.Drawing.Point(18, 6);
            this.gbNhap.Name = "gbNhap";
            this.gbNhap.Size = new System.Drawing.Size(663, 133);
            this.gbNhap.TabIndex = 5;
            this.gbNhap.TabStop = false;
            this.gbNhap.Text = "Thong tin hoa don";
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(418, 40);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(160, 27);
            this.cbMaNV.TabIndex = 20;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(131, 91);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(86, 18);
            this.lblNgayBan.TabIndex = 18;
            this.lblNgayBan.Text = "03/08/2003";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngay Nhap:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ma NV:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma HĐ:";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaHD.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(131, 40);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(160, 26);
            this.tbMaHD.TabIndex = 0;
            this.tbMaHD.TextChanged += new System.EventHandler(this.tbMaHD_TextChanged);
            // 
            // dataTT
            // 
            this.dataTT.AllowUserToAddRows = false;
            this.dataTT.AllowUserToDeleteRows = false;
            this.dataTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_TT,
            this.MaHH_TT,
            this.TenHH_TT,
            this.SLTK_TT,
            this.SLNQ_TT,
            this.DonViTinh_TT,
            this.HSD_TT,
            this.NoiSX_TT});
            this.dataTT.Location = new System.Drawing.Point(692, 32);
            this.dataTT.Margin = new System.Windows.Forms.Padding(8);
            this.dataTT.Name = "dataTT";
            this.dataTT.ReadOnly = true;
            this.dataTT.RowHeadersWidth = 51;
            this.dataTT.RowTemplate.Height = 24;
            this.dataTT.Size = new System.Drawing.Size(665, 163);
            this.dataTT.TabIndex = 4;
            // 
            // STT_TT
            // 
            this.STT_TT.HeaderText = "STT";
            this.STT_TT.MinimumWidth = 6;
            this.STT_TT.Name = "STT_TT";
            this.STT_TT.ReadOnly = true;
            // 
            // MaHH_TT
            // 
            this.MaHH_TT.HeaderText = "Mã hàng hóa";
            this.MaHH_TT.MinimumWidth = 6;
            this.MaHH_TT.Name = "MaHH_TT";
            this.MaHH_TT.ReadOnly = true;
            // 
            // TenHH_TT
            // 
            this.TenHH_TT.HeaderText = "Tên hàng hóa";
            this.TenHH_TT.MinimumWidth = 6;
            this.TenHH_TT.Name = "TenHH_TT";
            this.TenHH_TT.ReadOnly = true;
            // 
            // SLTK_TT
            // 
            this.SLTK_TT.HeaderText = "Số lượng trong kho";
            this.SLTK_TT.MinimumWidth = 6;
            this.SLTK_TT.Name = "SLTK_TT";
            this.SLTK_TT.ReadOnly = true;
            // 
            // SLNQ_TT
            // 
            this.SLNQ_TT.HeaderText = "Số lượng ngoài quầy";
            this.SLNQ_TT.MinimumWidth = 6;
            this.SLNQ_TT.Name = "SLNQ_TT";
            this.SLNQ_TT.ReadOnly = true;
            // 
            // DonViTinh_TT
            // 
            this.DonViTinh_TT.HeaderText = "Đơn vị tính";
            this.DonViTinh_TT.MinimumWidth = 6;
            this.DonViTinh_TT.Name = "DonViTinh_TT";
            this.DonViTinh_TT.ReadOnly = true;
            // 
            // HSD_TT
            // 
            this.HSD_TT.HeaderText = "Hạn sử dụng";
            this.HSD_TT.MinimumWidth = 6;
            this.HSD_TT.Name = "HSD_TT";
            this.HSD_TT.ReadOnly = true;
            // 
            // NoiSX_TT
            // 
            this.NoiSX_TT.HeaderText = "Nơi sản xuất";
            this.NoiSX_TT.MinimumWidth = 6;
            this.NoiSX_TT.Name = "NoiSX_TT";
            this.NoiSX_TT.ReadOnly = true;
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
            this.STT,
            this.ma_hh,
            this.ten_hh,
            this.so_luong,
            this.DonViTinh,
            this.gia_ban,
            this.thanh_tien,
            this.btn_sua,
            this.btn_xoa});
            this.dataCT.Location = new System.Drawing.Point(14, 224);
            this.dataCT.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.dataCT.Name = "dataCT";
            this.dataCT.ReadOnly = true;
            this.dataCT.RowHeadersWidth = 51;
            this.dataCT.RowTemplate.Height = 24;
            this.dataCT.Size = new System.Drawing.Size(1347, 354);
            this.dataCT.TabIndex = 3;
            this.dataCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCT_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
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
            // gia_ban
            // 
            this.gia_ban.HeaderText = "Giá bán";
            this.gia_ban.MinimumWidth = 6;
            this.gia_ban.Name = "gia_ban";
            this.gia_ban.ReadOnly = true;
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
            // 
            // btn_xoa
            // 
            this.btn_xoa.HeaderText = "Xóa";
            this.btn_xoa.MinimumWidth = 6;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ReadOnly = true;
            // 
            // ucBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucBanHang";
            this.Size = new System.Drawing.Size(1375, 708);
            this.Load += new System.EventHandler(this.ucBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            this.gbNhap.ResumeLayout(false);
            this.gbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTT;
        private System.Windows.Forms.DataGridView dataCT;
        private System.Windows.Forms.GroupBox gbNhap;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaHetCT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanh_tien;
        private System.Windows.Forms.DataGridViewButtonColumn btn_sua;
        private System.Windows.Forms.DataGridViewButtonColumn btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTK_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNQ_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD_TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSX_TT;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label7;
    }
}
