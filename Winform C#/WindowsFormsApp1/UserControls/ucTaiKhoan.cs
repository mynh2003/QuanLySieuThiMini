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

namespace WindowsFormsApp1.UserControls
{
    public partial class ucTaiKhoan : UserControl
    {
        DbConnection db = new DbConnection();
        public event EventHandler Logout;

        string _tkAdmin;
        public ucTaiKhoan(string tkAdmin)
        {
            InitializeComponent();
            this._tkAdmin = tkAdmin;
        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            gbForm.Text = "Dang Ky";
            btnThucHien.Text = "Dang Ky";
        }

        private void rdDangKy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDangKy.Checked)
            {
                gbForm.Text = "Dang Ky";
                btnThucHien.Text = "Dang Ky";
                label1.Text = "Mat Khau";
                label2.Text = "Nhap Lai Mat Khau";
                ClearTB();
            }         
        }

        private void rDoiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(rdDoiMatKhau.Checked)
            {
                gbForm.Text = "Doi Mat Khau";
                btnThucHien.Text = "Doi Mat Khau";
                label1.Text = "Mat Khau Cu";
                label2.Text = "Mat Khau Moi";
                ClearTB();
            }          
        }
        private void rdXoaTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXoaTaiKhoan.Checked)
            {
                gbForm.Text = "Xoa Tai Khoan";
                btnThucHien.Text = "Xoa Tai Khoan";
                label1.Text = "Mat Khau";
                label2.Text = "Nhap Lai Mat Khau";
                txtTaiKhoan.Text = _tkAdmin;
                txtTaiKhoan.Enabled = false;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            
            if (rdDangKy.Checked)
            {
                if (KiemTraTonTai())
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Tai Khoan da ton tai";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                if (textBox1.Text != textBox2.Text)
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Mat khau khong khop";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                string sql = "INSERT INTO ADMIN(TaiKhoan, MatKhau) VALUES('" + txtTaiKhoan.Text + @"', '" + textBox1.Text + @"')";
                db.changeData(sql);
                frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                f_MessgaesSuccess.messages = "Dang ky tai khoan thanh cong";
                f_MessgaesSuccess.ShowDialog();
                ClearTB();
            }
            else if(rdDoiMatKhau.Checked)
            {
                string sql = "SELECT MatKhau FROM ADMIN WHERE TaiKhoan ='"+txtTaiKhoan.Text +@"'";
                string matKhau = db.selectData(sql);
                if (matKhau != textBox1.Text)
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Mat khau khong dung";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                sql = "UPDATE ADMIN SET MatKhau = '"+textBox2.Text +@"' WHERE TaiKhoan ='" + txtTaiKhoan.Text + @"'";
                db.changeData(sql);
                frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                f_MessgaesSuccess.messages = "Doi mat khau thanh cong";
                f_MessgaesSuccess.ShowDialog();
                ClearTB();
            }
            else
            {
                string sql = "SELECT MatKhau FROM ADMIN WHERE TaiKhoan ='" + txtTaiKhoan.Text + @"'";
                string matKhau = db.selectData(sql);
                if (matKhau != textBox1.Text)
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Mat khau khong dung";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                if (textBox1.Text != textBox2.Text)
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Mat khau khong khop";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                frMessagesWarring f_MessagesWarring = new frMessagesWarring();
                f_MessagesWarring.messages = "Ban co chac chan xoa tai khoan nay \nkhong?";
                f_MessagesWarring.ShowDialog();


                if (f_MessagesWarring.isAgree)
                {

                    sql = @"DELETE FROM ADMIN WHERE( TaiKhoan ='" + txtTaiKhoan.Text + @"')";
                    db.changeData(sql);
                    frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                    f_MessgaesSuccess.messages = "Xoa Tai Khoan Thanh cong";
                    f_MessgaesSuccess.ShowDialog();
                    Logout(this, new EventArgs());
                }
                
            }
        }
        private bool KiemTraTonTai()
        {

            string sql = $"SELECT COUNT(*) FROM ADMIN WHERE TaiKhoan = N'" + txtTaiKhoan.Text + @"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
        }
        private void ClearTB()
        {
            txtTaiKhoan.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }        
    }
}
