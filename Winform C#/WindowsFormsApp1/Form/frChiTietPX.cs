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

namespace WindowsFormsApp1
{
    public partial class frChiTietPX : Form
    {
        DbConnection db = new DbConnection();
        string sql;
        string option;

        private bool mouseDown;
        private Point lastLocation;
        public frChiTietPX(string header)
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

        private void frChiTietPX_Load(object sender, EventArgs e)
        {
            load();
        }
        public string maHH, tenHH, soLuong, donViTinh;
        public delegate void GETDATA(string maHH, string tenHH, string soLuong, string donViTinh);
        public GETDATA mydata;
        public void GETVALUE(string maHH, string tenHH, string soLuongN, string donViTinh)
        {
            
            string soLuong = soLuongN.Replace(".", "");
            nSoLuong.Maximum = Convert.ToDecimal(soLuong);
            cbMaHH.Text = maHH;
            tbTenHH.Text = tenHH;
            nSoLuong.Value = Convert.ToDecimal(soLuong);
            tbDonViTinh.Text = donViTinh;
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
               nSoLuong.Text == "0")
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
         
            mydata(cbMaHH.Text, tbTenHH.Text, nSoLuong.Value.ToString(), tbDonViTinh.Text);
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

            sql = "SELECT SoLuongTrongKho FROM HANGHOA WHERE MaHH = N'" + cbMaHH.Text + @"'";
            nSoLuong.Maximum = Convert.ToDecimal(db.selectData(sql));
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
