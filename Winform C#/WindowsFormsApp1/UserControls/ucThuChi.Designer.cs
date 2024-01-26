namespace WindowsFormsApp1.UserControls
{
    partial class ucThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThuChi));
            this.pnControls = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grThongKe = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNgay = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.dataHT = new System.Windows.Forms.DataGridView();
            this.cbTuyChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(this.lblTongTien);
            this.pnControls.Controls.Add(this.label7);
            this.pnControls.Controls.Add(this.groupBox1);
            this.pnControls.Controls.Add(this.grThongKe);
            this.pnControls.Controls.Add(this.dataHT);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControls.Location = new System.Drawing.Point(0, 60);
            this.pnControls.Margin = new System.Windows.Forms.Padding(12);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(1375, 648);
            this.pnControls.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(691, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuc Nang";
            // 
            // grThongKe
            // 
            this.grThongKe.Controls.Add(this.cbNam);
            this.grThongKe.Controls.Add(this.cbThang);
            this.grThongKe.Controls.Add(this.cbNgay);
            this.grThongKe.Controls.Add(this.rdNam);
            this.grThongKe.Controls.Add(this.rdThang);
            this.grThongKe.Controls.Add(this.rdNgay);
            this.grThongKe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongKe.Location = new System.Drawing.Point(21, 15);
            this.grThongKe.Margin = new System.Windows.Forms.Padding(12);
            this.grThongKe.Name = "grThongKe";
            this.grThongKe.Size = new System.Drawing.Size(655, 150);
            this.grThongKe.TabIndex = 1;
            this.grThongKe.TabStop = false;
            this.grThongKe.Text = "Hien Thi Theo:";
            // 
            // cbNam
            // 
            this.cbNam.Enabled = false;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(457, 93);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 27);
            this.cbNam.TabIndex = 5;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // cbThang
            // 
            this.cbThang.Enabled = false;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(262, 93);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 27);
            this.cbThang.TabIndex = 4;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            this.cbThang.EnabledChanged += new System.EventHandler(this.cbThang_EnabledChanged);
            // 
            // cbNgay
            // 
            this.cbNgay.Enabled = false;
            this.cbNgay.FormattingEnabled = true;
            this.cbNgay.Location = new System.Drawing.Point(65, 93);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(121, 27);
            this.cbNgay.TabIndex = 3;
            this.cbNgay.EnabledChanged += new System.EventHandler(this.cbNgay_EnabledChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(482, 38);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(70, 23);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(283, 38);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(79, 23);
            this.rdThang.TabIndex = 1;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Thang";
            this.rdThang.UseVisualStyleBackColor = true;
            this.rdThang.CheckedChanged += new System.EventHandler(this.rdThang_CheckedChanged);
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Location = new System.Drawing.Point(88, 38);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(75, 23);
            this.rdNgay.TabIndex = 0;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Ngay";
            this.rdNgay.UseVisualStyleBackColor = true;
            this.rdNgay.CheckedChanged += new System.EventHandler(this.rdNgay_CheckedChanged);
            // 
            // dataHT
            // 
            this.dataHT.AllowUserToAddRows = false;
            this.dataHT.AllowUserToDeleteRows = false;
            this.dataHT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHT.Location = new System.Drawing.Point(14, 189);
            this.dataHT.Margin = new System.Windows.Forms.Padding(12);
            this.dataHT.Name = "dataHT";
            this.dataHT.ReadOnly = true;
            this.dataHT.RowHeadersWidth = 51;
            this.dataHT.RowTemplate.Height = 24;
            this.dataHT.Size = new System.Drawing.Size(1347, 389);
            this.dataHT.TabIndex = 0;
            this.dataHT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataHT_CellFormatting);
            // 
            // cbTuyChon
            // 
            this.cbTuyChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTuyChon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuyChon.FormattingEnabled = true;
            this.cbTuyChon.Items.AddRange(new object[] {
            "Tien nhap hang",
            "Tien ban hang",
            "Tien luong nhan vien"});
            this.cbTuyChon.Location = new System.Drawing.Point(127, 14);
            this.cbTuyChon.Name = "cbTuyChon";
            this.cbTuyChon.Size = new System.Drawing.Size(217, 31);
            this.cbTuyChon.TabIndex = 0;
            this.cbTuyChon.SelectedIndexChanged += new System.EventHandler(this.cbTuyChon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuy chon:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTuyChon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 60);
            this.panel1.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(129, 605);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 23);
            this.lblTongTien.TabIndex = 61;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tong Tien:";
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
            this.btnXuat.Location = new System.Drawing.Point(42, 29);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 3, 14, 3);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(101, 40);
            this.btnXuat.TabIndex = 31;
            this.btnXuat.Text = "       Xuat";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
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
            this.btnIn.Location = new System.Drawing.Point(42, 94);
            this.btnIn.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(101, 40);
            this.btnIn.TabIndex = 30;
            this.btnIn.Text = "       In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // ucThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucThuChi";
            this.Size = new System.Drawing.Size(1375, 708);
            this.Load += new System.EventHandler(this.ucThuChi_Load);
            this.pnControls.ResumeLayout(false);
            this.pnControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grThongKe.ResumeLayout(false);
            this.grThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.ComboBox cbTuyChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataHT;
        private System.Windows.Forms.GroupBox grThongKe;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.RadioButton rdNgay;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnIn;
    }
}
