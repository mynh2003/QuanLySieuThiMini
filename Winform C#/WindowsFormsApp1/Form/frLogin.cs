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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frLogin : Form
    {
        public bool isExit = false;
        bool isMaximized = false;
        bool isCheckMK = false;

        public string maNV;
        public string chucVu;

        public string userName;

        private bool mouseDown;
        private Point lastLocation;
        public frLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frLogin_Load(object sender, EventArgs e)
        {
            
        }
        public bool isThoat_DangNhap = true;
        DbConnection db= new DbConnection();
        string sql;
        public void clearDangNhap()
        {
            this.txtTaiKhoan.Clear();
            this.txtMatKhau.Clear();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            bool isQuanlyLogged = false;
            bool isNhanvienLogged = false;


            // Kiểm tra đăng nhập cho bảng "quản lý"
            sql = "select * from ADMIN";
            DataTable dtAD = db.readData(sql);
            foreach (DataRow row in dtAD.Rows)
            {
                if (txtTaiKhoan.Text == row[0].ToString() && txtMatKhau.Text == row[1].ToString())
                {
                    isQuanlyLogged = true;
                    userName = row[0].ToString();
                    break;
                }
            }
            sql = "select TaiKhoan, MatKhau, MaNV, ViTriLamViec from NHANVIEN  ";
            // Kiểm tra đăng nhập cho bảng "nhân viên"
            DataTable dtNV = db.readData(sql);
            foreach (DataRow row in dtNV.Rows)
            {
                if (txtTaiKhoan.Text == row[0].ToString() && txtMatKhau.Text == row[1].ToString())
                {
                    isNhanvienLogged = true;
                    maNV = row[2].ToString();
                    chucVu = row[3].ToString();
                    break;
                }
            }

            if (isQuanlyLogged)
            {
                
                frMenu_Admin f_QuanLy = new frMenu_Admin(userName);
                this.Hide();
                f_QuanLy.Show();
                f_QuanLy.Logout_MenuAdmin += F_QuanLy_Logout_MenuAdmin;
            }
            else if (isNhanvienLogged)
            {
                
                frMenu_Staff f_Staff = new frMenu_Staff(maNV,chucVu);
                this.Hide();
                f_Staff.Show();
                f_Staff.Logout_MenuStaff += F_Staff_Logout_MenuStaff;
                 

            }
            else
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ten dang nhap hoac mat khau \nkhong dung.";               
                f_MessgaesBox.ShowDialog();
                
            }
        }

        private void F_QuanLy_Logout_MenuAdmin(object sender, EventArgs e)
        {
            (sender as frMenu_Admin).isExit_MenuAdmin = false;
            (sender as frMenu_Admin).Dispose();
            this.clearDangNhap();
            this.Show();
        }

        private void F_Staff_Logout_MenuStaff(object sender, EventArgs e)
        {
            (sender as frMenu_Staff).isExit_MenuStaff = false;
            (sender as frMenu_Staff).Close();
            this.clearDangNhap();
            this.Show();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (isThoat_DangNhap)
            {
                Application.Exit();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (!isCheckMK)
            {
                this.txtMatKhau.UseSystemPasswordChar = false;
                isCheckMK = true;
            }
            else
            {
                this.txtMatKhau.UseSystemPasswordChar = true;
                isCheckMK = false;

            }
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {

            btnClose.BackColor = Color.FromArgb(30,50,94);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isExit)
            {
                Application.Exit();
            }
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

        

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Phóng to Form           
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

        private void frLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
