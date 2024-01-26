
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;
using System.Globalization;
using System.Web;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucBanHang : UserControl
    {
        DbConnection db = new DbConnection();
        string sql;

        bool isEnabled = false;

        int stt;

        public string maHH, tenHH, soLuong, giaBan;
        int index;
        int tongTien = 0;

        public ucBanHang()
        {
            InitializeComponent();
            
        }
        private void load()
        {
            btnHuy.BackColor = Color.Gray; 
            btnHuy.ForeColor = Color.White;
            btnXoaHetCT.BackColor = Color.Gray; 
            btnXoaHetCT.ForeColor = Color.White;
            btnOK.BackColor = Color.Gray;
            btnOK.ForeColor = Color.White;      
            btnThem.BackColor = Color.Gray; 
            btnThem.ForeColor = Color.White;
            dataCT.Enabled = false;
        }
        private void LoadDataTT()
        {
            dataTT.Rows.Clear();

            sql = "SELECT * FROM HANGHOA;";
            DataTable dt = db.readData(sql);
            int stt = 0;
            foreach (DataRow row in dt.Rows)
            {
                stt++;
                string maHH = row[0].ToString();
                string tenHH = row[1].ToString();
                string soLuongTK = row[2].ToString();
                string soLuongTKN = Convert.ToInt32(soLuongTK).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                string soLuongNQ = row[3].ToString();
                string soLuongNQN = Convert.ToInt32(soLuongNQ).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                string donViTinh = row[4].ToString();
                string hSD = row[5].ToString();
                string noiSX = row[6].ToString();
                dataTT.Rows.Add(stt, maHH, tenHH, soLuongTKN, soLuongNQN, donViTinh, hSD, noiSX);
            }
        }
        private void ucBanHang_Load(object sender, EventArgs e)
        {
            load();

            LoadDataTT();

            lblNgayBan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //đưa data và cbMaNV
            sql = "SELECT MaNV FROM NHANVIEN WHERE ViTriLamViec = 'Thu Ngân' ORDER  BY MaNV ASC ";
            DataTable dt_MaNV;
            dt_MaNV = db.readData(sql);
            List<string> ListMaNV = new List<string>();
            foreach (DataRow row in dt_MaNV.Rows)
            {
                ListMaNV.Add(row[0].ToString());
            }
            cbMaNV.Items.AddRange(ListMaNV.ToArray());
            
        }
        private void tbMaHD_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbMaHD.SelectionStart;
            tbMaHD.Text = tbMaHD.Text.ToUpper();
            tbMaHD.SelectionStart = selectionStart;
            tbMaHD.SelectionLength = 0;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbMaHD.Text) ||
               string.IsNullOrWhiteSpace(cbMaNV.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maHD = tbMaHD.Text;

            bool TonTaiMaHD = KiemTraTonTai("HOADON", "MaHD", maHD);

            if (TonTaiMaHD == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma hoa don da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            doiTrangThai();
        }
        private bool KiemTraTonTai(string tenBang, string tenTruong, string giaTri)
        {

            sql = $"SELECT COUNT(*) FROM {tenBang} WHERE {tenTruong} = N'" + giaTri + @"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
        }
        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            tbMaHD.Clear();
            cbMaNV.Text = null;
        }
        public void GETVALUE(string maHH, string tenHH, string soLuong, string donViTinh, string giaBan)
        {
            if (KiemTraMaHH(maHH))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma hang hoa da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            stt++;
            string soLuongN = Convert.ToInt32(soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));

            int thanhtien;
            thanhtien = Convert.ToInt32(soLuong) * Convert.ToInt32(giaBan.Replace(".", ""));
            string giaBanVND = giaBan + " VNĐ";
            string thanhTienVND = Convert.ToDecimal(thanhtien).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            dataCT.Rows.Add(stt, maHH, tenHH, soLuongN, donViTinh, giaBanVND, thanhTienVND, "Sửa", "Xóa");
            LoadTongTien();
        }
        public void EDITVALUE(string maHH, string tenHH, string soLuong, string donViTinh, string giaBan)
        {
            string soLuongN = Convert.ToInt32(soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            int thanhTien;
            thanhTien = Convert.ToInt32(soLuong) * Convert.ToInt32(giaBan.Replace(".", ""));
            string thanhTienVND = thanhTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            string giaBanVND = giaBan + " VNĐ";

            dataCT.Rows[index].Cells["ma_hh"].Value = maHH;
            dataCT.Rows[index].Cells["ten_hh"].Value = tenHH;
            dataCT.Rows[index].Cells["so_luong"].Value = soLuongN;
            dataCT.Rows[index].Cells["DonViTinh"].Value = donViTinh;
            dataCT.Rows[index].Cells["gia_ban"].Value = giaBanVND;
            dataCT.Rows[index].Cells["thanh_tien"].Value = thanhTienVND;
            LoadTongTien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frChiTietHD f = new frChiTietHD("Them");
            f.mydata = new frChiTietHD.GETDATA(GETVALUE);
            f.ShowDialog();

        }
        public bool KiemTraMaHH(string giaTriKT)
        {
            string valueToCheck = giaTriKT;
            var columnValues = dataCT.Rows.Cast<DataGridViewRow>()
                .Select(row => row.Cells["ma_hh"].Value.ToString())
                .ToList();

            bool valueExists = columnValues.Contains(valueToCheck);
            return valueExists;
        }
        private void LoadTongTien()
        {
            string thanhTienVND, thanhtien;
            tongTien = 0;
            foreach (DataGridViewRow row in dataCT.Rows)
            {
                thanhTienVND = row.Cells["thanh_tien"].Value.ToString();
                thanhtien = thanhTienVND.Replace(".", "").Replace(" VNĐ", "");
                tongTien += Convert.ToInt32(thanhtien);
            }
            lblTongTien.Text = tongTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
        }
        private void dataCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataCT.Columns[e.ColumnIndex].Name == "btn_sua")
            {

                index = e.RowIndex;
                string maHH = dataCT.Rows[index].Cells["ma_hh"].Value.ToString();
                string tenHH = dataCT.Rows[index].Cells["ten_hh"].Value.ToString();
                string soLuong = dataCT.Rows[index].Cells["so_luong"].Value.ToString();
                string donViTinh = dataCT.Rows[index].Cells["DonViTinh"].Value.ToString();
                string giaBan = dataCT.Rows[index].Cells["gia_ban"].Value.ToString();
                frChiTietHD f = new frChiTietHD("Sua");
                f.GETVALUE(maHH, tenHH, soLuong, donViTinh, giaBan);
                f.mydata = new frChiTietHD.GETDATA(EDITVALUE);
                f.ShowDialog();
            }
            else if (e.RowIndex >= 0 && dataCT.Columns[e.ColumnIndex].Name == "btn_xoa")
            {
                index = e.RowIndex;
                frMessagesWarring f = new frMessagesWarring();
                f.messages = "Ban co muon xoa mat hang nay khong?";
                f.ShowDialog();
                if (!f.isAgree)
                {
                    return;
                }
                dataCT.Rows.RemoveAt(index);
                LoadTongTien();
            }
        }
        private void btnXoaHetCT_Click(object sender, EventArgs e)
        {
            dataCT.Rows.Clear();
            LoadTongTien();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!(dataCT.RowCount > 0))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap chi tiet hoa don";
                f_MessgaesBox.ShowDialog();
                return;
            }
            frThanhToanHD f_ThanhToanHD = new frThanhToanHD(lblTongTien.Text);
            f_ThanhToanHD.ShowDialog();
            if (f_ThanhToanHD.isAgree)
            {
                SaveData();
                frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                f_MessgaesSuccess.messages = "Luu hoa don thanh cong";
                f_MessgaesSuccess.ShowDialog();
                ResetForm();
                doiTrangThai();
            }

        }
        private void SaveData()
        {
            //xử lý dữ liệu lưu vào các bảng ở databse
            string maHD = tbMaHD.Text;
            string maNV = cbMaNV.Text;
            DateTime currentTime = DateTime.Now;
            TimeSpan thoiGianTao = new TimeSpan(currentTime.Hour, currentTime.Minute, 0);

            DateTime ngay = DateTime.ParseExact(lblNgayBan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayNhap = ngay.ToString("yyyy/MM/dd");

            //xử lý data và lưu vào bảng HOADON
            sql = "INSERT INTO HOADON (MaHD, MaNV, ThoiGianTao, NgayTao, TongTien) VALUES ('" + maHD + @"', '" + maNV + @"','" + thoiGianTao.ToString(@"hh\:mm\:ss") + @"','" + ngayNhap + @"', '" + tongTien + @"')";
            db.changeData(sql);


            //xử lý data và lưu vào bảng CT_PHIEUNHAP và bảng HANGHOA
            foreach (DataGridViewRow row in dataCT.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maHH = row.Cells["ma_hh"].Value.ToString();
                    string soLuongN = row.Cells["so_luong"].Value.ToString();
                    string soLuong = soLuongN.Replace(".", "").Replace(" VNĐ", "");
                    string giaBan = row.Cells["gia_ban"].Value.ToString().Replace(".", "").Replace(" VNĐ", "");

                    sql = "SELECT SoLuongNgoaiQuay FROM HANGHOA WHERE MaHH = '" + maHH + @"'";
                    int soLuongCu = Convert.ToInt32(db.selectData(sql));
                    int soLuongMoi = soLuongCu - Convert.ToInt32(soLuong);

                    sql = "UPDATE HANGHOA SET SoluongNgoaiQuay = '" + soLuongMoi + @"' WHERE MaHH = '" + maHH + @"'";
                    db.changeData(sql);
                    sql = "INSERT INTO CT_HOADON (MaHD, MaHH, SoLuong, GiaBan) VALUES ('" + maHD + @"', '" + maHH + @"','" + soLuong + @"','" + giaBan + @"')";
                    db.changeData(sql);
                }
            }
        }

        private void ResetForm()
        {
            tbMaHD.Text = string.Empty;
            cbMaNV.Text = string.Empty;
            dataCT.Rows.Clear();
            LoadTongTien();
            LoadDataTT();
        }
        private void doiTrangThai()
        {
            if (!isEnabled)
            {

                btnOK.Enabled = true;
                btnXoaHetCT.Enabled = true;
                btnThem.Enabled = true;
                btnHuy.Enabled = true;
                dataCT.Enabled = true;
                gbNhap.Enabled = false;
                btnNhap.Enabled = false;
                btnXoaPhieu.Enabled = false;
                isEnabled = true;
            }
            else
            {

                btnHuy.Enabled = false;
                btnXoaHetCT.Enabled = false;
                btnOK.Enabled = false;
                btnThem.Enabled = false;
                dataCT.Enabled = false;
                gbNhap.Enabled = true;
                btnNhap.Enabled = true;
                btnXoaPhieu.Enabled = true;
                isEnabled = false;
            }
        }
        private void btnNhap_EnabledChanged(object sender, EventArgs e)
        {
                if (!btnNhap.Enabled)
                {
                    btnNhap.BackColor = Color.Gray; 
                    btnNhap.ForeColor = Color.White; 
                }
                else
                {
                    btnNhap.BackColor = Color.FromArgb(30, 50, 94); 
                    btnNhap.ForeColor = Color.White; 
                }
        }

        private void btnXoaPhieu_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXoaPhieu.Enabled)
            {
                btnXoaPhieu.BackColor = Color.Gray; 
                btnXoaPhieu.ForeColor = Color.White; 
            }
            else
            {
                btnXoaPhieu.BackColor = Color.Red; 
                btnXoaPhieu.ForeColor = Color.White; 
            }
        }
        private void btnHuy_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnHuy.Enabled)
            {
                btnHuy.BackColor = Color.Gray; 
                btnHuy.ForeColor = Color.White;
            }
            else
            {
                btnHuy.BackColor = Color.Red; 
                btnHuy.ForeColor = Color.White; 
            }
        }

        private void btnXoaHetCT_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXoaHetCT.Enabled)
            {
                btnXoaHetCT.BackColor = Color.Gray; 
                btnXoaHetCT.ForeColor = Color.White; 
            }
            else
            {
                btnXoaHetCT.BackColor = Color.Red; 
                btnXoaHetCT.ForeColor = Color.White; 
            }
        }

        private void btnOK_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnOK.Enabled)
            {
                btnOK.BackColor = Color.Gray; 
                btnOK.ForeColor = Color.White; 
            }
            else
            {
                btnOK.BackColor = Color.SeaGreen; 
                btnOK.ForeColor = Color.White; 
            }
        }
        private void btnThem_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnThem.Enabled)
            {
                btnThem.BackColor = Color.Gray;
                btnThem.ForeColor = Color.White;
            }
            else
            {
                btnThem.BackColor = Color.FromArgb(30, 50, 94);
                btnThem.ForeColor = Color.White;
            }
        }

    }
}
