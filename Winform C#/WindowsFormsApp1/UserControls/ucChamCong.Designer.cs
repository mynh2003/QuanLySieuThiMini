namespace WindowsFormsApp1.UserControls
{
    partial class ucChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChamCong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnControls = new System.Windows.Forms.Panel();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.dataChiaCa = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCa3 = new System.Windows.Forms.CheckBox();
            this.cbCa2 = new System.Windows.Forms.CheckBox();
            this.cbCa1 = new System.Windows.Forms.CheckBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVTLV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuTuCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiNVKho = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NVThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiNVThuNgan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.pnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiaCa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 60);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(628, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cham Cong";
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(this.btnChamCong);
            this.pnControls.Controls.Add(this.dataChiaCa);
            this.pnControls.Controls.Add(this.label11);
            this.pnControls.Controls.Add(this.groupBox1);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControls.Location = new System.Drawing.Point(0, 60);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(1387, 660);
            this.pnControls.TabIndex = 7;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(12, 295);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(14);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(182, 45);
            this.btnChamCong.TabIndex = 39;
            this.btnChamCong.Text = "       Cham Cong";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // dataChiaCa
            // 
            this.dataChiaCa.AllowUserToAddRows = false;
            this.dataChiaCa.AllowUserToDeleteRows = false;
            this.dataChiaCa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataChiaCa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChiaCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChiaCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Ngay,
            this.ThuTuCa,
            this.NVKho,
            this.TrangThaiNVKho,
            this.NVThuNgan,
            this.TrangThaiNVThuNgan});
            this.dataChiaCa.Location = new System.Drawing.Point(483, 58);
            this.dataChiaCa.Margin = new System.Windows.Forms.Padding(12);
            this.dataChiaCa.Name = "dataChiaCa";
            this.dataChiaCa.ReadOnly = true;
            this.dataChiaCa.RowHeadersWidth = 51;
            this.dataChiaCa.RowTemplate.Height = 24;
            this.dataChiaCa.Size = new System.Drawing.Size(887, 590);
            this.dataChiaCa.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(479, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Danh sach chia ca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVTLV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbCa3);
            this.groupBox1.Controls.Add(this.cbCa2);
            this.groupBox1.Controls.Add(this.cbCa1);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            // 
            // cbCa3
            // 
            this.cbCa3.AutoSize = true;
            this.cbCa3.Enabled = false;
            this.cbCa3.Location = new System.Drawing.Point(284, 73);
            this.cbCa3.Name = "cbCa3";
            this.cbCa3.Size = new System.Drawing.Size(38, 22);
            this.cbCa3.TabIndex = 10;
            this.cbCa3.Text = "3";
            this.cbCa3.UseVisualStyleBackColor = true;
            // 
            // cbCa2
            // 
            this.cbCa2.AutoSize = true;
            this.cbCa2.Enabled = false;
            this.cbCa2.Location = new System.Drawing.Point(214, 73);
            this.cbCa2.Name = "cbCa2";
            this.cbCa2.Size = new System.Drawing.Size(38, 22);
            this.cbCa2.TabIndex = 9;
            this.cbCa2.Text = "2";
            this.cbCa2.UseVisualStyleBackColor = true;
            // 
            // cbCa1
            // 
            this.cbCa1.AutoSize = true;
            this.cbCa1.Enabled = false;
            this.cbCa1.Location = new System.Drawing.Point(144, 73);
            this.cbCa1.Name = "cbCa1";
            this.cbCa1.Size = new System.Drawing.Size(38, 22);
            this.cbCa1.TabIndex = 8;
            this.cbCa1.Text = "1";
            this.cbCa1.UseVisualStyleBackColor = true;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(141, 161);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(111, 19);
            this.lblTenNV.TabIndex = 7;
            this.lblTenNV.Text = "Lê Bình Minh";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(141, 118);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(59, 19);
            this.lblMaNV.TabIndex = 6;
            this.lblMaNV.Text = "NV007";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(141, 32);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(91, 19);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "03/08/2003";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ten NV:";
            // 
            // lblVTLV
            // 
            this.lblVTLV.AutoSize = true;
            this.lblVTLV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVTLV.Location = new System.Drawing.Point(141, 204);
            this.lblVTLV.Name = "lblVTLV";
            this.lblVTLV.Size = new System.Drawing.Size(50, 19);
            this.lblVTLV.TabIndex = 12;
            this.lblVTLV.Text = "VTLV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vi Tri Lam Viec:";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // ThuTuCa
            // 
            this.ThuTuCa.HeaderText = "Thứ tự ca";
            this.ThuTuCa.MinimumWidth = 6;
            this.ThuTuCa.Name = "ThuTuCa";
            this.ThuTuCa.ReadOnly = true;
            // 
            // NVKho
            // 
            this.NVKho.HeaderText = "NV kho";
            this.NVKho.MinimumWidth = 6;
            this.NVKho.Name = "NVKho";
            this.NVKho.ReadOnly = true;
            // 
            // TrangThaiNVKho
            // 
            this.TrangThaiNVKho.HeaderText = "Trạng thái NV kho";
            this.TrangThaiNVKho.MinimumWidth = 6;
            this.TrangThaiNVKho.Name = "TrangThaiNVKho";
            this.TrangThaiNVKho.ReadOnly = true;
            // 
            // NVThuNgan
            // 
            this.NVThuNgan.HeaderText = "NV Thu Ngân";
            this.NVThuNgan.MinimumWidth = 6;
            this.NVThuNgan.Name = "NVThuNgan";
            this.NVThuNgan.ReadOnly = true;
            // 
            // TrangThaiNVThuNgan
            // 
            this.TrangThaiNVThuNgan.HeaderText = "Trạng thái NV thu ngân";
            this.TrangThaiNVThuNgan.MinimumWidth = 6;
            this.TrangThaiNVThuNgan.Name = "TrangThaiNVThuNgan";
            this.TrangThaiNVThuNgan.ReadOnly = true;
            this.TrangThaiNVThuNgan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiNVThuNgan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ucChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucChamCong";
            this.Size = new System.Drawing.Size(1387, 720);
            this.Load += new System.EventHandler(this.ucChamCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiaCa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridView dataChiaCa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.CheckBox cbCa3;
        private System.Windows.Forms.CheckBox cbCa2;
        private System.Windows.Forms.CheckBox cbCa1;
        private System.Windows.Forms.Label lblVTLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuTuCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVKho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiNVKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVThuNgan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiNVThuNgan;
    }
}
