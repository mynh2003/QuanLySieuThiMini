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
using WindowsFormsApp1.Models;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class frChiTietPN : Form
    {
        DbConnection db = new DbConnection();
        string sql;
        string option;

        private bool mouseDown;
        private Point lastLocation;
        public frChiTietPN(string header)
        {
            InitializeComponent();
            option = header;
            lblHeader.Text = header;
            if(header == "Sua")
            {
               cbMaHH.Enabled= false;
                btnThaoTac.Text = header;
            }
            else if(header == "Them")
            {
                btnThaoTac.Text = header;
            }    
        }
        private void frChiTietPN_Load(object sender, EventArgs e)
        {
            
            load();
        }
        public string maHH, tenHH, soLuong,donViTinh, giaNhap;
        public delegate void GETDATA(string maHH, string tenHH, string soLuong,string donViTinh, string giaNhap);
        public GETDATA mydata;
        public void GETVALUE(string maHH, string tenHH, string soLuongN ,string donViTinh, string giaNhapVND)
        {
            cbMaHH.Text = maHH;
            tbTenHH.Text = tenHH;
            string soLuong = soLuongN.Replace(".", "");
            nSoLuong.Value = Convert.ToDecimal(soLuong);
            tbDonViTinh.Text = donViTinh;
            tbGiaNhap.Text = giaNhapVND.Replace(".", "").Replace(" VNĐ", ""); ;

        }
        private void load()
        {
            sql = "SELECT MaHH FROM HANGHOA ORDER  BY MaHH ASC ";
            DataTable dt_MaHH;
            dt_MaHH = db.readData(sql);
            List<string> ListMaHH = new List<string>();
            // Lặp qua DataTable và thêm giá trị vào List
            foreach (DataRow row in dt_MaHH.Rows)
            {
                ListMaHH.Add(row[0].ToString());
            }
            cbMaHH.Items.AddRange(ListMaHH.ToArray());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaHH.Text) ||
              string.IsNullOrWhiteSpace(tbTenHH.Text) ||
              string.IsNullOrWhiteSpace(tbGiaNhap.Text) ||
               nSoLuong.Text == "0")
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            mydata(cbMaHH.Text, tbTenHH.Text, nSoLuong.Value.ToString(), tbDonViTinh.Text, tbGiaNhap.Text);


            if (option == "Sua")
            {

                this.Dispose();
            }        
        }
        
        private void cbMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT TenHH FROM HANGHOA WHERE MaHH='" + cbMaHH.Text + @"'";
            tbTenHH.Text = db.selectData(sql);
            sql = "SELECT DonViTinh FROM HANGHOA WHERE MaHH='" + cbMaHH.Text + @"'";
            tbDonViTinh.Text = db.selectData(sql);
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (tbGiaNhap.Text.Length > 13)
            {

                tbGiaNhap.Text = tbGiaNhap.Text.Substring(0, 13);
                tbGiaNhap.Select(tbGiaNhap.Text.Length, 0);
            }
            else
            {
                tbGiaNhap.Text = FormatNumberToVND(tbGiaNhap.Text.Replace(".", ""));
                tbGiaNhap.Select(tbGiaNhap.Text.Length, 0);
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

    }
}
