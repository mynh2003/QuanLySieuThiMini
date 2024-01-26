namespace WindowsFormsApp1.UserControls
{
    partial class ucTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnControls = new System.Windows.Forms.Panel();
            this.rdDangKy = new System.Windows.Forms.RadioButton();
            this.rdDoiMatKhau = new System.Windows.Forms.RadioButton();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.rdXoaTaiKhoan = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.pnControls.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.rdXoaTaiKhoan);
            this.panel1.Controls.Add(this.rdDoiMatKhau);
            this.panel1.Controls.Add(this.rdDangKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 60);
            this.panel1.TabIndex = 2;
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(this.gbForm);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnControls.Location = new System.Drawing.Point(0, 60);
            this.pnControls.Margin = new System.Windows.Forms.Padding(12);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(1375, 648);
            this.pnControls.TabIndex = 4;
            // 
            // rdDangKy
            // 
            this.rdDangKy.AutoSize = true;
            this.rdDangKy.Checked = true;
            this.rdDangKy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDangKy.ForeColor = System.Drawing.Color.White;
            this.rdDangKy.Location = new System.Drawing.Point(21, 18);
            this.rdDangKy.Name = "rdDangKy";
            this.rdDangKy.Size = new System.Drawing.Size(100, 23);
            this.rdDangKy.TabIndex = 0;
            this.rdDangKy.TabStop = true;
            this.rdDangKy.Text = "Dang Ky";
            this.rdDangKy.UseVisualStyleBackColor = true;
            this.rdDangKy.CheckedChanged += new System.EventHandler(this.rdDangKy_CheckedChanged);
            // 
            // rdDoiMatKhau
            // 
            this.rdDoiMatKhau.AutoSize = true;
            this.rdDoiMatKhau.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.rdDoiMatKhau.Location = new System.Drawing.Point(161, 18);
            this.rdDoiMatKhau.Name = "rdDoiMatKhau";
            this.rdDoiMatKhau.Size = new System.Drawing.Size(139, 23);
            this.rdDoiMatKhau.TabIndex = 1;
            this.rdDoiMatKhau.Text = "Doi Mat Khau";
            this.rdDoiMatKhau.UseVisualStyleBackColor = true;
            this.rdDoiMatKhau.CheckedChanged += new System.EventHandler(this.rDoiMatKhau_CheckedChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(64, 91);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(290, 36);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTenDangNhap.Location = new System.Drawing.Point(61, 53);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(160, 23);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Ten Dang Nhap";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(61, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mat Khau";
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btnThucHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThucHien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.White;
            this.btnThucHien.Location = new System.Drawing.Point(62, 398);
            this.btnThucHien.Margin = new System.Windows.Forms.Padding(24);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(290, 45);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(30)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(325, 184);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(28, 28);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // gbForm
            // 
            this.gbForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbForm.BackColor = System.Drawing.Color.White;
            this.gbForm.Controls.Add(this.iconButton1);
            this.gbForm.Controls.Add(this.label2);
            this.gbForm.Controls.Add(this.textBox2);
            this.gbForm.Controls.Add(this.iconButton2);
            this.gbForm.Controls.Add(this.btnThucHien);
            this.gbForm.Controls.Add(this.label1);
            this.gbForm.Controls.Add(this.textBox1);
            this.gbForm.Controls.Add(this.lblTenDangNhap);
            this.gbForm.Controls.Add(this.txtTaiKhoan);
            this.gbForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbForm.Location = new System.Drawing.Point(480, 91);
            this.gbForm.Margin = new System.Windows.Forms.Padding(0);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(0);
            this.gbForm.Size = new System.Drawing.Size(414, 467);
            this.gbForm.TabIndex = 6;
            this.gbForm.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(61, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhap Lai Mat Khau";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(64, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 36);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))), ((int)(((byte)(30)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(325, 274);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 28);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // rdXoaTaiKhoan
            // 
            this.rdXoaTaiKhoan.AutoSize = true;
            this.rdXoaTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.rdXoaTaiKhoan.Location = new System.Drawing.Point(340, 18);
            this.rdXoaTaiKhoan.Name = "rdXoaTaiKhoan";
            this.rdXoaTaiKhoan.Size = new System.Drawing.Size(149, 23);
            this.rdXoaTaiKhoan.TabIndex = 2;
            this.rdXoaTaiKhoan.Text = "Xoa Tai Khoan";
            this.rdXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.rdXoaTaiKhoan.CheckedChanged += new System.EventHandler(this.rdXoaTaiKhoan_CheckedChanged);
            // 
            // ucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucTaiKhoan";
            this.Size = new System.Drawing.Size(1375, 708);
            this.Load += new System.EventHandler(this.ucTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnControls.ResumeLayout(false);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdDoiMatKhau;
        private System.Windows.Forms.RadioButton rdDangKy;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.GroupBox gbForm;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdXoaTaiKhoan;
    }
}
