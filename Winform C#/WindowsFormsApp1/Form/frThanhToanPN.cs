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
    public partial class frThanhToanPN : Form
    {
        string _congNoVND;
        
        public frThanhToanPN(string congNoVND)
        {
            InitializeComponent();
            this._congNoVND = congNoVND;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool isAgree = false;
        public string tienThanhToan;
        public delegate void GETDATA(string tienThanhToan);
        public GETDATA mydata;
        private void frThanhToanPN_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            isAgree = true;
            
            if (string.IsNullOrWhiteSpace(tbThanhToan.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap tien thanh toan";
                f_MessgaesBox.ShowDialog();
                return;
            }
            int congNo = Convert.ToInt32(_congNoVND.Replace(".", "").Replace(" VNĐ", ""));
            int thanhToan = Convert.ToInt32(tbThanhToan.Text.Replace(".", ""));
            if (congNo <  thanhToan)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Tien thanh toan vuot qua cong no";
                f_MessgaesBox.ShowDialog();
                return;
            }
            mydata(tbThanhToan.Text);
            this.Dispose();
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (tbThanhToan.Text.Length > 13)
            {
                // Nếu độ dài chuỗi vượt quá 13 ký tự, không chấp nhận giá trị nhập vào
            
                tbThanhToan.Text = tbThanhToan.Text.Substring(0, 13); // Giữ lại chỉ 13 ký tự đầu tiên
                tbThanhToan.Select(tbThanhToan.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
            }
            else
            {
                tbThanhToan.Text = FormatNumberToVND(tbThanhToan.Text.Replace(".", ""));
                tbThanhToan.Select(tbThanhToan.Text.Length, 0); // Di chuyển con trỏ đến cuối TextBox
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
