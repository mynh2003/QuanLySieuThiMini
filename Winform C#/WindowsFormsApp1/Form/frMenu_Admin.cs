using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class frMenu_Admin : Form
    {
        int panelWidth;
        bool isCollapsed;

        bool isMaximized = false;

        private bool mouseDown;
        private Point lastLocation;

        public bool isExit_MenuAdmin = false;
        public event EventHandler Logout_MenuAdmin;

        string _userName;
        public frMenu_Admin(string userName)
        {
            InitializeComponent();
            this._userName = userName;
            
            

            this.StartPosition = FormStartPosition.CenterScreen;
           
            ucTrangChu uc_TrangChu = new ucTrangChu();
            addControlsToPanel(uc_TrangChu);

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = _userName;
            // Thiết lập interval cho Timer (1000 milliseconds = 1 giây)
            timerTime.Interval = 1000;
            // Bắt đầu Timer
            timerTime.Start();

            panelWidth = panLeft.Width;
            isCollapsed = false;
        }

        private void load_index(int y)
        {
            int x = this.pnClick.Location.X;
            this.pnClick.Location = new Point(x, y);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panLeft.Width = panLeft.Width + 10;
                if(panLeft.Width >= panelWidth)
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

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isExit_MenuAdmin)
            {
                Application.Exit();
            }
        }

        

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout_MenuAdmin(this, new EventArgs());   
        }

       

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
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
            this.WindowState = FormWindowState.Minimized;
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
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            int y = this.btnBanHang.Location.Y;
            load_index(y);
            ucBanHang uc_BanHang = new ucBanHang();
            addControlsToPanel(uc_BanHang);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int y = this.btnNCC.Location.Y;
            load_index(y);
            ucNCC uc_NCC = new ucNCC();
            addControlsToPanel(uc_NCC);
        }
        private void btnChiaCa_Click(object sender, EventArgs e)
        {
            int y = this.btnChiaCa.Location.Y;
            load_index(y);
            ucChiaCaNV uc_ChiaCaNV = new ucChiaCaNV();
            addControlsToPanel(uc_ChiaCaNV);
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            int y = this.btnNhanVien.Location.Y;
            load_index(y);
            ucNhanVien uc_NhanVien = new ucNhanVien();
            addControlsToPanel(uc_NhanVien);
        }
        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            int y = this.btnHangHoa.Location.Y;
            load_index(y);
            ucHangHoa uc_HangHoa = new ucHangHoa();
            addControlsToPanel(uc_HangHoa);
        }
        
        

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            int y = this.btnThuChi.Location.Y;
            load_index(y);
            ucThuChi uc_ThuChi = new ucThuChi();
            addControlsToPanel(uc_ThuChi);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int y = this.btnThongKe.Location.Y;
            load_index(y);
            ucThongKe uc_ThongKe = new ucThongKe();
            addControlsToPanel(uc_ThongKe);
        }

        

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frThongTinPM f_ThongTinPM = new frThongTinPM();
            f_ThongTinPM.StartPosition = FormStartPosition.CenterScreen;
            f_ThongTinPM.ShowDialog();

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ucTaiKhoan uc_TaiKhoan = new ucTaiKhoan(_userName);
            addControlsToPanel(uc_TaiKhoan);
            uc_TaiKhoan.Logout += Uc_TaiKhoan_Logout;
        }

        private void Uc_TaiKhoan_Logout(object sender, EventArgs e)
        {
            Logout_MenuAdmin(this, new EventArgs());
        }
    }
}
