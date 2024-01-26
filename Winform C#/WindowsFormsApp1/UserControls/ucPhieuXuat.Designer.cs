namespace WindowsFormsApp1.UserControls
{
    partial class ucPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhieuXuat));
            this.label1 = new System.Windows.Forms.Label();
            this.gbXuat = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPX = new System.Windows.Forms.TextBox();
            this.dataCT = new System.Windows.Forms.DataGridView();
            this.STT_PhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_hh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnXoaHetCT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(627, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phieu Xuat";
            // 
            // gbXuat
            // 
            this.gbXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbXuat.Controls.Add(this.cbMaNV);
            this.gbXuat.Controls.Add(this.lblNgayXuat);
            this.gbXuat.Controls.Add(this.label9);
            this.gbXuat.Controls.Add(this.label10);
            this.gbXuat.Controls.Add(this.label2);
            this.gbXuat.Controls.Add(this.tbMaPX);
            this.gbXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXuat.Location = new System.Drawing.Point(14, 51);
            this.gbXuat.Name = "gbXuat";
            this.gbXuat.Size = new System.Drawing.Size(876, 127);
            this.gbXuat.TabIndex = 20;
            this.gbXuat.TabStop = false;
            this.gbXuat.Text = "Thong tin phieu xuat";
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(404, 50);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(160, 27);
            this.cbMaNV.TabIndex = 20;
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXuat.Location = new System.Drawing.Point(709, 55);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(86, 18);
            this.lblNgayXuat.TabIndex = 19;
            this.lblNgayXuat.Text = "03/08/2003";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(620, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngay Xuat:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(301, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ma NV Xuat:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma PX:";
            // 
            // tbMaPX
            // 
            this.tbMaPX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaPX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaPX.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaPX.Location = new System.Drawing.Point(111, 50);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(160, 26);
            this.tbMaPX.TabIndex = 0;
            this.tbMaPX.TextChanged += new System.EventHandler(this.tbMaPX_TextChanged);
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
            this.STT_PhieuNhap,
            this.ma_hh,
            this.ten_hh,
            this.so_luong,
            this.DonViTinh,
            this.btnSua,
            this.btnXoa});
            this.dataCT.Enabled = false;
            this.dataCT.Location = new System.Drawing.Point(14, 224);
            this.dataCT.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dataCT.Name = "dataCT";
            this.dataCT.ReadOnly = true;
            this.dataCT.RowHeadersWidth = 51;
            this.dataCT.RowTemplate.Height = 24;
            this.dataCT.Size = new System.Drawing.Size(1347, 354);
            this.dataCT.TabIndex = 21;
            this.dataCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCT_CellContentClick_1);
            // 
            // STT_PhieuNhap
            // 
            this.STT_PhieuNhap.HeaderText = "STT";
            this.STT_PhieuNhap.MinimumWidth = 6;
            this.STT_PhieuNhap.Name = "STT_PhieuNhap";
            this.STT_PhieuNhap.ReadOnly = true;
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
            // btnSua
            // 
            this.btnSua.HeaderText = "Sửa";
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            this.btnSua.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "Xóa";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Chi tiet phieu xuat";
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
            this.btnNhap.Location = new System.Drawing.Point(909, 61);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(132, 45);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "       Nhap";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.EnabledChanged += new System.EventHandler(this.btnNhap_EnabledChanged);
            this.btnNhap.Click += new System.EventHandler(this.btnNhapPhieu_Click);
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
            this.btnXoaPhieu.Location = new System.Drawing.Point(909, 127);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(132, 45);
            this.btnXoaPhieu.TabIndex = 18;
            this.btnXoaPhieu.Text = "       Xoa het";
            this.btnXoaPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.EnabledChanged += new System.EventHandler(this.btnXoaPhieu_EnabledChanged);
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
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
            this.btnXoaHetCT.Location = new System.Drawing.Point(1073, 595);
            this.btnXoaHetCT.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnXoaHetCT.Name = "btnXoaHetCT";
            this.btnXoaHetCT.Size = new System.Drawing.Size(132, 40);
            this.btnXoaHetCT.TabIndex = 50;
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
            this.btnHuy.Location = new System.Drawing.Point(1229, 595);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 40);
            this.btnHuy.TabIndex = 49;
            this.btnHuy.Text = "       Huy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.EnabledChanged += new System.EventHandler(this.btnHuy_EnabledChanged);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnThem.Location = new System.Drawing.Point(761, 595);
            this.btnThem.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 40);
            this.btnThem.TabIndex = 48;
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
            this.btnOK.Location = new System.Drawing.Point(917, 595);
            this.btnOK.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(132, 40);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "       OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.EnabledChanged += new System.EventHandler(this.btnOK_EnabledChanged);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoaHetCT);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataCT);
            this.Controls.Add(this.gbXuat);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucPhieuXuat";
            this.Size = new System.Drawing.Size(1375, 648);
            this.Load += new System.EventHandler(this.ucPhieuXuat_Load);
            this.gbXuat.ResumeLayout(false);
            this.gbXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbXuat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaPX;
        private System.Windows.Forms.DataGridView dataCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnXoaHetCT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_PhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_hh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}
