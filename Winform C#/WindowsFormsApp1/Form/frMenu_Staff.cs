using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class frMenu_Staff : Form
    {
        DbConnection db = new DbConnection();
        int panelWidth;
        bool isCollapsed;

        bool isMaximized = false;

        public event EventHandler Logout_MenuStaff;

        private bool mouseDown;
        private Point lastLocation;

        public bool isExit_MenuStaff = false;

        string _maNV, _chucVu;
        public frMenu_Staff(string maNV, string chucVu)
        {
            InitializeComponent();
            this._maNV = maNV;
            this._chucVu = chucVu;
            

            this.StartPosition = FormStartPosition.CenterScreen;
            
            ucTrangChu uc_TrangChu = new ucTrangChu();
            addControlsToPanel(uc_TrangChu);
        }

        private void frMenu_staff_Load(object sender, EventArgs e)
        {
            // Thiết lập interval cho Timer (1000 milliseconds = 1 giây)
            timerTime.Interval = 1000;
            // Bắt đầu Timer
            timerTime.Start();
            
            panelWidth = panLeft.Width;
            isCollapsed = false;

            string sql = "SELECT TenNV FROM NHANVIEN WHERE MaNV = '" + _maNV + @"'";
            lblUserName.Text = db.selectData(sql);
            lblChucVu.Text = _chucVu;
        }
        private void load_index(int y)
        {
            int x = this.pnClick.Location.X;
            this.pnClick.Location = new Point(x, y);

        }

        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControls.Controls.Clear();
            pnControls.Controls.Add(c);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            int y = this.btnTrangChu.Location.Y;
            load_index(y);
            ucTrangChu uc_TrangChu = new ucTrangChu();
            addControlsToPanel(uc_TrangChu);
        }
        private void btnNhaKho_Click(object sender, EventArgs e)
        {
            int y = this.btnNhaKho.Location.Y;
            load_index(y);
            ucNhaKho uc_NhaKho = new ucNhaKho();
            addControlsToPanel(uc_NhaKho);
            ;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            int y = this.btnBanHang.Location.Y;
            load_index(y);
            ucBanHang uc_BanHang = new ucBanHang();
            addControlsToPanel(uc_BanHang);

        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            int y = this.btnChamCong.Location.Y;
            load_index(y);
            ucChamCong uc_ChamCong = new ucChamCong(_maNV);
            addControlsToPanel(uc_ChamCong);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout_MenuStaff(this, new EventArgs());  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isCollapsed)
            {
                panLeft.Width = panLeft.Width + 10;
                if (panLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panLeft.Width = panLeft.Width - 10;
                if (panLeft.Width <= 56)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnCollap_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if(!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Phóng to Form 

        }

    }
}
