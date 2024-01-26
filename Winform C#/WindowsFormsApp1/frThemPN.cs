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
    public partial class frNhap : Form
    {
        DbConnection db = new DbConnection();
        string sql;
        string option;
        
        public frNhap(string header)
        {
            InitializeComponent();
            lblhe
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            mydata(cbMaHH.Text, tbTenHH.Text, nSoLuong.Value.ToString(), tbGiaNhap.Text);
            //ucPhieuNhap uc = new ucPhieuNhap();
            //uc.LoadTongTien();
        }
        

     

        private void frNhap_Load(object sender, EventArgs e)
        {
           
            load();
        }
        public string maHH, tenHH, soLuong, giaNhap;
        public delegate void GETDATA(string maHH, string tenHH, string soLuong, string giaNhap);
        public GETDATA mydata;
        
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

        private void cbMaHH_SelectedIndexChanged(object sender, EventArgs e)
        {
                sql = "SELECT TenHH FROM HANGHOA WHERE MaHH='" + cbMaHH.Text + @"'";
                tbTenHH.Text = db.selectData(sql);
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
