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

namespace WindowsFormsApp1
{
    public partial class frChiTietHD : Form
    {
        DbConnection db = new DbConnection();
        string sql;
        string option;

        private bool mouseDown;
        private Point lastLocation;
        public frChiTietHD(string header)
        {
            InitializeComponent();
            option = header;
            lblHeader.Text = header;
            if (header == "Sua")
            {
                cbMaHH.Enabled = false;
                btnThaoTac.Text = header;
            }
            else if (header == "Them")
            {
                btnThaoTac.Text = header;
            }
        }

        private void frChiTietHD_Load(object sender, EventArgs e)
        {
            load();
        }
        public string maHH, tenHH, soLuong, donViTinh, giaBan;
        public delegate void GETDATA(string maHH, string tenHH, string soLuong, string donViTinh, string giaBan);
        public GETDATA mydata;
        public void GETVALUE(string maHH, string tenHH, string soLuongN, string donViTinh, string giaBanVND)
        {
            cbMaHH.Text = maHH;
            tbTenHH.Text = tenHH;
            string soLuong = soLuongN.Replace(".", "");
            nSoLuong.Value = Convert.ToDecimal(soLuong);
            tbDonViTinh.Text = donViTinh;
            tbGiaBan.Text = giaBanVND.Replace(".", "").Replace(" VNĐ", ""); ;

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
              string.IsNullOrWhiteSpace(tbGiaBan.Text) ||
               nSoLuong.Text == "0")
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            mydata(cbMaHH.Text, tbTenHH.Text, nSoLuong.Value.ToString(), tbDonViTinh.Text, tbGiaBan.Text);


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
            sql = "SELECT SoLuongNgoaiQuay FROM HANGHOA WHERE MaHH='" + cbMaHH.Text + @"'";
            nSoLuong.Maximum = Convert.ToDecimal(db.selectData(sql)); ;
        }
        private void tbGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (tbGiaBan.Text.Length > 13)
            {

                tbGiaBan.Text = tbGiaBan.Text.Substring(0, 13);
                tbGiaBan.Select(tbGiaBan.Text.Length, 0);
            }
            else
            {
                tbGiaBan.Text = FormatNumberToVND(tbGiaBan.Text.Replace(".", ""));
                tbGiaBan.Select(tbGiaBan.Text.Length, 0);
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
