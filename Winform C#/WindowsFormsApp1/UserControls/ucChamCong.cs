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
    public partial class ucChamCong : UserControl
    {
        DbConnection db = new DbConnection();

        string _maNV;

        bool isChamCong = false;
        public ucChamCong(string maNV)
        {
            InitializeComponent();
            this._maNV = maNV;
        }
        private void ucChamCong_Load(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");

            LoadThongTin();
            LoadDataChiaCa();
        }
        private void LoadThongTin()
        {
            ClearRadio();
            string sql = "SELECT ThuTuCa FROM CANHANVIEN WHERE Ngay ='" + DateTime.Now.ToString("yyyy/MM/dd") + @"' AND ((NhanVienKho='" + _maNV + @"' AND TrangThaiNVKho = '"+false+ @"') OR(NhanVienThuNgan='" + _maNV + @"' AND TrangThaiNVThuNgan = '"+false+@"')) ";
            DataTable dt = db.readData(sql);
            foreach(DataRow row in dt.Rows)
            {
                switch (Convert.ToInt32(row[0].ToString()))
                {
                    case 1:
                        cbCa1.Checked = true;
                        isChamCong = false;
                        break;
                    case 2:
                        cbCa2.Checked = true;
                        isChamCong = false;
                        break;
                    case 3:
                        cbCa3.Checked = true;
                        isChamCong = false;
                        break;
                }
            }
            lblMaNV.Text = _maNV;
             sql = "SELECT TenNV FROM NHANVIEN WHERE MaNV ='" + _maNV + @"'";
            lblTenNV.Text = db.selectData(sql);
            sql = "SELECT ViTriLamViec FROM NHANVIEN WHERE MaNV ='" + _maNV + @"'";
            lblVTLV.Text = db.selectData(sql);
        }

        private void ClearRadio()
        {
            cbCa1.Checked = false;
            cbCa2.Checked = false;
            cbCa3.Checked = false;

        }
        private void LoadDataChiaCa()
        {
            dataChiaCa.Rows.Clear();
            string sql = "SELECT * FROM CANHANVIEN";
            DataTable dt = db.readData(sql);
            TruyenGiaTri(dt);

        }
        private void TruyenGiaTri(DataTable dt)
        {
            int stt = 0;
            foreach (DataRow row in dt.Rows)
            {
                DateTime ngayLong = Convert.ToDateTime(row[0].ToString());
                string ngayShort = ngayLong.ToString("dd/MM/yyyy");
                string thuTuCa = row[1].ToString();
                string nhanVienKho = row[2].ToString();
                bool trangThaiNVKho = Convert.ToBoolean(row[3].ToString());
                string nhanVienThuNgan = row[4].ToString();
                bool trangThaiNVThuNgan = Convert.ToBoolean(row[5].ToString());
                dataChiaCa.Rows.Add(stt, ngayShort, thuTuCa, nhanVienKho, trangThaiNVKho, nhanVienThuNgan, trangThaiNVThuNgan);
            }
        }
        private void ChamCong(string ca)
        {
            if(lblVTLV.Text == "Kho")
            {
                string sql = $"UPDATE CANHANVIEN SET TrangThaiNVKho = '" + true + @"' WHERE Ngay ='" + DateTime.Now.ToString("yyyy/MM/dd") + @"' AND ThuTuCa='" + ca + @"'  AND NhanVienKho='" + _maNV + @"' AND TrangThaiNVKho = '" + false + @"'";
                db.changeData(sql);
            }
            else
            {
                string sql = $"UPDATE CANHANVIEN SET TrangThaiNVThuNgan = '" + true + @"' WHERE Ngay ='" + DateTime.Now.ToString("yyyy/MM/dd") + @"' AND ThuTuCa='" + ca + @"'  AND NhanVienThuNgan='" + _maNV + @"' AND TrangThaiNVThuNgan = '" + false + @"'";
                db.changeData(sql);
            }
            
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (!isChamCong)
            {
                string ca = "";

                if (cbCa1.Checked)
                {
                    ca = "1";

                }
                else if (cbCa2.Checked)
                {
                    ca = "2";
                }
                else if (cbCa3.Checked)
                {
                    ca = "3";
                }
                else
                {
                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Ban khong co ca nao";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
                ChamCong(ca);
                frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                f_MessgaesSuccess.messages = "Da cham cong";
                f_MessgaesSuccess.ShowDialog();
                
                
                isChamCong = true;
                LoadThongTin();
                LoadDataChiaCa();
                if (isChamCong)
                {
                    btnChamCong.BackColor = Color.SeaGreen;
                }
            }
            
        }
    }
}
