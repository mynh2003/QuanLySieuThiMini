namespace WindowsFormsApp1.UserControls
{
    partial class ucDSHangCanNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDSHangCanNhap));
            this.dataHH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTrongKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNgoaiQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDieuKien = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHH
            // 
            this.dataHH.AllowUserToAddRows = false;
            this.dataHH.AllowUserToDeleteRows = false;
            this.dataHH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHH,
            this.TenHH,
            this.SLTrongKho,
            this.SLNgoaiQuay,
            this.DonViTinh,
            this.HSD,
            this.NoiSX});
            this.dataHH.Location = new System.Drawing.Point(14, 82);
            this.dataHH.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dataHH.Name = "dataHH";
            this.dataHH.ReadOnly = true;
            this.dataHH.RowHeadersWidth = 51;
            this.dataHH.RowTemplate.Height = 24;
            this.dataHH.Size = new System.Drawing.Size(1347, 554);
            this.dataHH.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.FillWeight = 37.51914F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaHH
            // 
            this.MaHH.FillWeight = 128.3887F;
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            // 
            // TenHH
            // 
            this.TenHH.FillWeight = 118.708F;
            this.TenHH.HeaderText = "Tên hàng hóa";
            this.TenHH.MinimumWidth = 6;
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            // 
            // SLTrongKho
            // 
            this.SLTrongKho.FillWeight = 111.6898F;
            this.SLTrongKho.HeaderText = "Số lượng trong kho";
            this.SLTrongKho.MinimumWidth = 6;
            this.SLTrongKho.Name = "SLTrongKho";
            this.SLTrongKho.ReadOnly = true;
            // 
            // SLNgoaiQuay
            // 
            this.SLNgoaiQuay.FillWeight = 112.3405F;
            this.SLNgoaiQuay.HeaderText = "Số lượng ngoài quầy";
            this.SLNgoaiQuay.MinimumWidth = 6;
            this.SLNgoaiQuay.Name = "SLNgoaiQuay";
            this.SLNgoaiQuay.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.FillWeight = 98.29368F;
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // HSD
            // 
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            // 
            // NoiSX
            // 
            this.NoiSX.HeaderText = "Nơi sản xuất";
            this.NoiSX.MinimumWidth = 6;
            this.NoiSX.Name = "NoiSX";
            this.NoiSX.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sach hang hoa can nhap";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(773, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "So luong hang trong kho <=";
            // 
            // tbDieuKien
            // 
            this.tbDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDieuKien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDieuKien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDieuKien.Location = new System.Drawing.Point(1016, 33);
            this.tbDieuKien.Name = "tbDieuKien";
            this.tbDieuKien.Size = new System.Drawing.Size(100, 28);
            this.tbDieuKien.TabIndex = 12;
            this.tbDieuKien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDieuKien_KeyPress);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(1260, 26);
            this.btnIn.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 40);
            this.btnIn.TabIndex = 27;
            this.btnIn.Text = "       In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1146, 26);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(101, 40);
            this.btnXuat.TabIndex = 29;
            this.btnXuat.Text = "       Xuat";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // ucDSHangCanNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tbDieuKien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHH);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucDSHangCanNhap";
            this.Size = new System.Drawing.Size(1375, 648);
            this.Load += new System.EventHandler(this.ucDSHangCanNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDieuKien;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNgoaiQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSX;
    }
}
