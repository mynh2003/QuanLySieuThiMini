namespace WindowsFormsApp1
{
    partial class frMenu_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenu_Admin));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMaxmize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panLeft = new System.Windows.Forms.Panel();
            this.btnChiaCa = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThuChi = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhaKho = new System.Windows.Forms.Button();
            this.pnClick = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCollap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnControls = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.panLeft.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.label6);
            this.pnHeader.Controls.Add(this.btnMaxmize);
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Controls.Add(this.lblTime);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1600, 40);
            this.pnHeader.TabIndex = 1;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(747, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(0, 23);
            this.label6.TabIndex = 12;
            // 
            // btnMaxmize
            // 
            this.btnMaxmize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxmize.FlatAppearance.BorderSize = 0;
            this.btnMaxmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxmize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxmize.Image")));
            this.btnMaxmize.Location = new System.Drawing.Point(1520, 0);
            this.btnMaxmize.Name = "btnMaxmize";
            this.btnMaxmize.Size = new System.Drawing.Size(40, 40);
            this.btnMaxmize.TabIndex = 11;
            this.btnMaxmize.UseVisualStyleBackColor = true;
            this.btnMaxmize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1480, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1560, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.lblTime.Location = new System.Drawing.Point(11, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(106, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // panLeft
            // 
            this.panLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panLeft.Controls.Add(this.btnTaiKhoan);
            this.panLeft.Controls.Add(this.btnChiaCa);
            this.panLeft.Controls.Add(this.btnHangHoa);
            this.panLeft.Controls.Add(this.btnNCC);
            this.panLeft.Controls.Add(this.btnInfo);
            this.panLeft.Controls.Add(this.btnThongKe);
            this.panLeft.Controls.Add(this.btnThuChi);
            this.panLeft.Controls.Add(this.btnNhanVien);
            this.panLeft.Controls.Add(this.btnBanHang);
            this.panLeft.Controls.Add(this.btnNhaKho);
            this.panLeft.Controls.Add(this.pnClick);
            this.panLeft.Controls.Add(this.btnTrangChu);
            this.panLeft.Controls.Add(this.panel8);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.ForeColor = System.Drawing.Color.Black;
            this.panLeft.Location = new System.Drawing.Point(0, 40);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(213, 860);
            this.panLeft.TabIndex = 11;
            // 
            // btnChiaCa
            // 
            this.btnChiaCa.FlatAppearance.BorderSize = 0;
            this.btnChiaCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiaCa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiaCa.ForeColor = System.Drawing.Color.White;
            this.btnChiaCa.Image = ((System.Drawing.Image)(resources.GetObject("btnChiaCa.Image")));
            this.btnChiaCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiaCa.Location = new System.Drawing.Point(12, 320);
            this.btnChiaCa.Name = "btnChiaCa";
            this.btnChiaCa.Size = new System.Drawing.Size(203, 60);
            this.btnChiaCa.TabIndex = 16;
            this.btnChiaCa.Text = "       Chia ca";
            this.btnChiaCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiaCa.UseVisualStyleBackColor = true;
            this.btnChiaCa.Click += new System.EventHandler(this.btnChiaCa_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnHangHoa.Image")));
            this.btnHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.Location = new System.Drawing.Point(12, 500);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(203, 60);
            this.btnHangHoa.TabIndex = 15;
            this.btnHangHoa.Text = "       Hang Hoa";
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(12, 380);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(203, 60);
            this.btnNCC.TabIndex = 14;
            this.btnNCC.Text = "       NCC";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(12, 827);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(12, 620);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(203, 60);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "       Thong Ke";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThuChi
            // 
            this.btnThuChi.FlatAppearance.BorderSize = 0;
            this.btnThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuChi.ForeColor = System.Drawing.Color.White;
            this.btnThuChi.Image = ((System.Drawing.Image)(resources.GetObject("btnThuChi.Image")));
            this.btnThuChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuChi.Location = new System.Drawing.Point(12, 560);
            this.btnThuChi.Name = "btnThuChi";
            this.btnThuChi.Size = new System.Drawing.Size(203, 60);
            this.btnThuChi.TabIndex = 8;
            this.btnThuChi.Text = "       Thu Chi";
            this.btnThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuChi.UseVisualStyleBackColor = true;
            this.btnThuChi.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(12, 440);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(203, 60);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "       Nhan Vien";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(12, 260);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(203, 60);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "       Ban Hang\r\n";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnNhaKho
            // 
            this.btnNhaKho.FlatAppearance.BorderSize = 0;
            this.btnNhaKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaKho.ForeColor = System.Drawing.Color.White;
            this.btnNhaKho.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaKho.Image")));
            this.btnNhaKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaKho.Location = new System.Drawing.Point(12, 200);
            this.btnNhaKho.Name = "btnNhaKho";
            this.btnNhaKho.Size = new System.Drawing.Size(203, 60);
            this.btnNhaKho.TabIndex = 4;
            this.btnNhaKho.Text = "       Nha Kho";
            this.btnNhaKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaKho.UseVisualStyleBackColor = true;
            this.btnNhaKho.Click += new System.EventHandler(this.btnNhaKho_Click);
            // 
            // pnClick
            // 
            this.pnClick.BackColor = System.Drawing.Color.White;
            this.pnClick.Location = new System.Drawing.Point(0, 140);
            this.pnClick.Name = "pnClick";
            this.pnClick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnClick.Size = new System.Drawing.Size(10, 60);
            this.pnClick.TabIndex = 3;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(11, 140);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(203, 60);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "       Trang Chu";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCollap);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(213, 140);
            this.panel8.TabIndex = 1;
            // 
            // btnCollap
            // 
            this.btnCollap.FlatAppearance.BorderSize = 0;
            this.btnCollap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollap.ForeColor = System.Drawing.Color.Transparent;
            this.btnCollap.Image = ((System.Drawing.Image)(resources.GetObject("btnCollap.Image")));
            this.btnCollap.Location = new System.Drawing.Point(12, 8);
            this.btnCollap.Margin = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.btnCollap.Name = "btnCollap";
            this.btnCollap.Size = new System.Drawing.Size(25, 25);
            this.btnCollap.TabIndex = 12;
            this.btnCollap.UseVisualStyleBackColor = true;
            this.btnCollap.Click += new System.EventHandler(this.btnCollap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblNameUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(213, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 140);
            this.panel1.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1315, 37);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 60);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 74);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.White;
            this.lblNameUser.Location = new System.Drawing.Point(134, 37);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameUser.Size = new System.Drawing.Size(85, 23);
            this.lblNameUser.TabIndex = 2;
            this.lblNameUser.Text = "Admin1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chao:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(213, 888);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 12);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1588, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 708);
            this.panel3.TabIndex = 14;
            // 
            // pnControls
            // 
            this.pnControls.BackColor = System.Drawing.Color.Gainsboro;
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Location = new System.Drawing.Point(213, 180);
            this.pnControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnControls.Name = "pnControls";
            this.pnControls.Padding = new System.Windows.Forms.Padding(12);
            this.pnControls.Size = new System.Drawing.Size(1375, 708);
            this.pnControls.TabIndex = 15;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(12, 786);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(25, 25);
            this.btnTaiKhoan.TabIndex = 17;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // frMenu_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frMenu_Admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.panLeft.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThuChi;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhaKho;
        private System.Windows.Forms.Panel pnClick;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCollap;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMaxmize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnChiaCa;
        private System.Windows.Forms.Button btnTaiKhoan;
    }
}