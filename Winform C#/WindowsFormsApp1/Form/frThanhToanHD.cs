using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frThanhToanHD : Form
    {
        string _tongTien;

        bool isNext = false;


        public bool isAgree = false;

        public frThanhToanHD(string tongTien)
        {
            InitializeComponent();
            this._tongTien = tongTien;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frThanhToanHD_Load(object sender, EventArgs e)
        {
            tbTongTien.Text = _tongTien.Replace("VNĐ","");
            tbKhachTra.ReadOnly = false;
            btnQuayLai.Text = "Exit";
            btnOk.Text = "Next";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (isNext)
            {
                LoadButton();
            }
            else
            {
                this.Dispose();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isNext)
            {
                isAgree = true;
                this.Dispose();

            }
            else
            {
                if (string.IsNullOrWhiteSpace(tbKhachTra.Text))
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Vui long nhap so tien khach tra";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                int tongTien = Convert.ToInt32(tbTongTien.Text.Replace(".", ""));
                int khachTra = Convert.ToInt32(tbKhachTra.Text.Replace(".", ""));
                if(khachTra < tongTien)
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "So tien khong du thanh toan";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                int tienThua = khachTra - tongTien;
                tbTienThua.Text = tienThua.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                LoadButton();
            }
        }
        private void LoadButton()
        {
            if (!isNext) 
            {
                tbKhachTra.ReadOnly = true;
                btnQuayLai.Text = "Back";
                btnOk.Text = "OK";    
                isNext = true;
            }
            else
            {
                tbKhachTra.ReadOnly = false;
                btnQuayLai.Text = "Exit";
                btnOk.Text = "Next";
                isNext = false;
            }
        }
        private void tbKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (tbKhachTra.Text.Length > 13)
            {
                // Nếu độ dài chuỗi vượt quá 13 ký tự, không chấp nhận giá trị nhập vào

                tbKhachTra.Text = tbKhachTra.Text.Substring(0, 13); // Giữ lại chỉ 13 ký tự đầu tiên
                tbKhachTra.Select(tbKhachTra.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
            }
            else
            {
                tbKhachTra.Text = FormatNumberToVND(tbKhachTra.Text.Replace(".", ""));
                tbKhachTra.Select(tbKhachTra.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
            }
        }
        private string FormatNumberToVND(string input)
        {
            if (long.TryParse(input, out long number))
            {
                return number.ToString("#,##0", CultureInfo.GetCultureInfo("vi-VN"));
            }
            return input;
        }
    }
}
