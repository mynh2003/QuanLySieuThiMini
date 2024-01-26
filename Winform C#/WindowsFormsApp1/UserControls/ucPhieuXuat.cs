
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

namespace WindowsFormsApp1.UserControls
{
    public partial class ucPhieuXuat : UserControl
    {
        DbConnection db = new DbConnection();
        bool isEnabled = false;
        string sql;
        int stt;
        public string maHH, tenHH, soLuong;
        int index;
        int tongTien = 0;
        public ucPhieuXuat()
        {
            InitializeComponent();
            load();
        }
        public void load()
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
        private void ucPhieuXuat_Load(object sender, EventArgs e)
        {
            lblNgayXuat.Text = DateTime.Now.ToString("dd/MM/yyyy");

            sql = "SELECT MaNV FROM NHANVIEN WHERE ViTriLamViec = 'Kho' ORDER  BY MaNV ASC ";
            DataTable dt_MaNV;
            dt_MaNV = db.readData(sql);
            List<string> ListMaNV = new List<string>();
            // Lặp qua DataTable và thêm giá trị vào List
            foreach (DataRow row in dt_MaNV.Rows)
            {
                ListMaNV.Add(row[0].ToString());
            }
            cbMaNV.Items.AddRange(ListMaNV.ToArray());
            
        }
        private void tbMaPX_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbMaPX.SelectionStart;
            tbMaPX.Text = tbMaPX.Text.ToUpper();
            tbMaPX.SelectionStart = selectionStart;
            tbMaPX.SelectionLength = 0;
        }
        private void btnNhapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaPX.Text) ||
               string.IsNullOrWhiteSpace(cbMaNV.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maPX = tbMaPX.Text;

            bool TonTaiMaPN = KiemTraTonTai("PHIEUXUAT", "MaPX", maPX);

            if (TonTaiMaPN == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma phieu xuat da ton tai";
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
            tbMaPX.Clear();
            cbMaNV.Text = null;
        }

        public void GETVALUE(string maHH, string tenHH, string soLuong, string donViTinh)
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
            dataCT.Rows.Add(stt, maHH, tenHH, soLuongN, donViTinh, "Sửa", "Xóa");


        }
        public void EDITVALUE(string maHH, string tenHH, string soLuong, string donViTinh)
        {
            string soLuongN = Convert.ToInt32(soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));

            dataCT.Rows[index].Cells["ma_hh"].Value = maHH;
            dataCT.Rows[index].Cells["ten_hh"].Value = tenHH;
            dataCT.Rows[index].Cells["so_luong"].Value = soLuongN;
            dataCT.Rows[index].Cells["DonViTinh"].Value = donViTinh;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frChiTietPX f = new frChiTietPX("Them");
            f.mydata = new frChiTietPX.GETDATA(GETVALUE);
            f.ShowDialog();      

        }
        public bool KiemTraMaHH(string giaTriKT)
        {
            // Kiểm tra tồn tại của giá trị trong cột cụ thể
            string valueToCheck = giaTriKT; // Giá trị cần kiểm tra
            var columnValues = dataCT.Rows.Cast<DataGridViewRow>()
                .Select(row => row.Cells["ma_hh"].Value.ToString())
                .ToList();

            bool valueExists = columnValues.Contains(valueToCheck);
            return valueExists;
        }

        private void dataCT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataCT.Columns[e.ColumnIndex].Name == "btnSua")
            {

                index = e.RowIndex;
                string maHH = dataCT.Rows[index].Cells["ma_hh"].Value.ToString();
                string tenHH = dataCT.Rows[index].Cells["ten_hh"].Value.ToString();
                string soLuong = dataCT.Rows[index].Cells["so_luong"].Value.ToString();
                string donViTinh = dataCT.Rows[index].Cells["DonViTinh"].Value.ToString();     
                frChiTietPX f = new frChiTietPX("Sua");
                f.GETVALUE(maHH, tenHH, soLuong, donViTinh);
                f.mydata = new frChiTietPX.GETDATA(EDITVALUE);
                f.ShowDialog();
    
            }
            else if (e.RowIndex >= 0 && dataCT.Columns[e.ColumnIndex].Name == "btnXoa")
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
            }
        }
        private void btnXoaHetCT_Click(object sender, EventArgs e)
        {
            dataCT.Rows.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!(dataCT.RowCount > 0))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap chi tiet phieu nhap";
                f_MessgaesBox.ShowDialog();
                return;           
            }
            SaveData();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Luu phieu nhap thanh cong";
            f_MessgaesSuccess.ShowDialog();
            ResetForm();
            doiTrangThai();
        }

        private void SaveData()
        {
            //xử lý dữ liệu lưu vào các bảng ở databse
            string maPX = tbMaPX.Text;
            string maNV = cbMaNV.Text;
            DateTime tg = DateTime.ParseExact(lblNgayXuat.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayXuat = tg.ToString("yyyy/MM/dd");

            //xử lý data và lưu vào bảng PHIEUXHUAT
            sql = "INSERT INTO PHIEUXUAT (MaPX,  MaNV, NgayXuat) VALUES ('" + maPX + @"','" + maNV + @"','" + ngayXuat + @"')";
            db.changeData(sql);

            //xử lý data và lưu vào bảng CT_PHIEUXUAT và HANGHOA
            foreach (DataGridViewRow row in dataCT.Rows)
            {
                if (!row.IsNewRow)
                {

                    string maHH = row.Cells["ma_hh"].Value.ToString();
                    string soLuongN = row.Cells["so_luong"].Value.ToString();
                    string soLuong = soLuongN.Replace(".", "").Replace(" VNĐ", "");
                    // Lấy giá trị từ các cột khác tương tự ở đây
                    sql = "SELECT SoLuongTrongKho FROM HANGHOA WHERE MaHH = '" + maHH + @"'";
                    int slTK = Convert.ToInt32(db.selectData(sql));
                    sql = "SELECT SoLuongNgoaiQuay FROM HANGHOA WHERE MaHH = '" + maHH + @"'";
                    int slNQ = Convert.ToInt32(db.selectData(sql));
                    int slTKMoi = slTK - Convert.ToInt32(soLuong);
                    int slNQMoi = slNQ + Convert.ToInt32(soLuong);

                    sql = "UPDATE HANGHOA SET SoluongTrongKho = '" + slTKMoi + @"', SoluongNgoaiQuay = '" + slNQMoi + @"' WHERE MaHH = '" + maHH + @"'";
                    db.changeData(sql);
                    sql = "INSERT INTO CT_PHIEUXUAT (MaPX, MaHH, SoLuong) VALUES ('" + maPX + @"', '" + maHH + @"','" + soLuong + @"')";
                    db.changeData(sql);
                }
            }
        }
        private void ResetForm()
        {
            tbMaPX.Text = string.Empty;
            cbMaNV.Text = string.Empty;
            dataCT.Rows.Clear();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            doiTrangThai();
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
                gbXuat.Enabled = false;
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
                gbXuat.Enabled = true;
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
