using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucPhieuNhap : UserControl
    {
        DbConnection db = new DbConnection();
        string sql;

        bool isEnabled = false;
        
        int stt;

        public string maHH, tenHH, soLuong, giaNhap;
        int index;
        int tongTien = 0;
        public ucPhieuNhap()
        {
            InitializeComponent();
            load();
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

      
        private void ucPhieuNhap_Load(object sender, EventArgs e)
        {
            lblNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //đưa data và cbMaNV
            sql = "SELECT MaNV FROM NHANVIEN WHERE ViTriLamViec = 'Kho' ORDER  BY MaNV ASC ";
            DataTable dt_MaNV;
            dt_MaNV = db.readData(sql);
            List<string> ListMaNV = new List<string>();
            foreach (DataRow row in dt_MaNV.Rows)
            {
                ListMaNV.Add(row[0].ToString());
            }
            cbMaNV.Items.AddRange(ListMaNV.ToArray());

            //đưa data và cbMaNCC
            sql = "SELECT MaNCC FROM NHACUNGCAP ORDER  BY MaNCC ASC ";
            DataTable dt_MaNCC;
            dt_MaNCC = db.readData(sql);
            List<string> ListMaNCC = new List<string>();
            foreach (DataRow row in dt_MaNCC.Rows)
            {
                ListMaNCC.Add(row[0].ToString());
            }
            cbMaNCC.Items.AddRange(ListMaNCC.ToArray());

        }

        private void tbMaPN_TextChanged_1(object sender, EventArgs e)
        {
            int selectionStart = tbMaPN.SelectionStart;
            tbMaPN.Text = tbMaPN.Text.ToUpper();
            tbMaPN.SelectionStart = selectionStart;
            tbMaPN.SelectionLength = 0;
        }
        private void btnNhapPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaPN.Text) ||
                string.IsNullOrWhiteSpace(cbMaNCC.Text) ||
               string.IsNullOrWhiteSpace(cbMaNV.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maPN = tbMaPN.Text;

            bool TonTaiMaPN = KiemTraTonTai("PHIEUNHAP","MaPN", maPN);

            if (TonTaiMaPN == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma phieu nhap da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            doiTrangThai();
            LoadCongNo();
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
            tbMaPN.Clear();
            cbMaNCC.Text = null;
            cbMaNV.Text = null;
        }


        public void GETVALUE(string maHH, string tenHH, string soLuong, string donViTinh, string giaNhap)
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
            thanhtien = Convert.ToInt32(soLuong) * Convert.ToInt32(giaNhap.Replace(".", ""));       
            string giaNhapVND = giaNhap + " VNĐ";
            string thanhTienVND = Convert.ToDecimal(thanhtien).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            dataCT.Rows.Add(stt, maHH, tenHH, soLuongN, donViTinh, giaNhapVND, thanhTienVND, "Sửa", "Xóa");
            LoadTongTien();
            LoadCongNo();

        }
        public void EDITVALUE(string maHH, string tenHH, string soLuong, string donViTinh, string giaNhap)
        {
            string soLuongN = Convert.ToInt32(soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            int thanhTien;
            thanhTien = Convert.ToInt32(soLuong) * Convert.ToInt32(giaNhap.Replace(".", ""));
            string thanhTienVND = thanhTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
            string giaNhapVND = giaNhap + " VNĐ";

            dataCT.Rows[index].Cells["ma_hh"].Value = maHH;
            dataCT.Rows[index].Cells["ten_hh"].Value = tenHH;
            dataCT.Rows[index].Cells["so_luong"].Value = soLuongN;
            dataCT.Rows[index].Cells["DonViTinh"].Value = donViTinh;
            dataCT.Rows[index].Cells["gia_nhap"].Value = giaNhapVND;
            dataCT.Rows[index].Cells["thanh_tien"].Value = thanhTienVND;
            LoadTongTien();
            LoadCongNo();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frChiTietPN f = new frChiTietPN("Them");
            f.mydata = new frChiTietPN.GETDATA(GETVALUE);
            f.ShowDialog();    

        }
        public bool KiemTraMaHH(string giaTriKT)
        {
            // Kiểm tra tồn tại của giá trị trong cột cụ thể
            string valueToCheck = giaTriKT; // Giá trị cần kiểm tra
            var columnValues = dataCT.Rows.Cast<DataGridViewRow>().Select(row => row.Cells["ma_hh"].Value.ToString()).ToList();
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
        private void LoadCongNo()
        {
            sql = "SELECT CongNo FROM NHACUNGCAP WHERE MaNCC = '" + cbMaNCC.Text + @"'";
            int congNo = Convert.ToInt32(db.selectData(sql));
            string thanhTienVND, thanhtien;
            foreach (DataGridViewRow row in dataCT.Rows)
            {
                thanhTienVND = row.Cells["thanh_tien"].Value.ToString();
                thanhtien = thanhTienVND.Replace(".", "").Replace(" VNĐ", "");
                congNo += Convert.ToInt32(thanhtien);
            }
            lblCongNo.Text = congNo.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
        }
        private void dataCT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataCT.Columns[e.ColumnIndex].Name == "btn_sua")
            {

                index = e.RowIndex;
                string maHH = dataCT.Rows[index].Cells["ma_hh"].Value.ToString();
                string tenHH = dataCT.Rows[index].Cells["ten_hh"].Value.ToString();
                string soLuong = dataCT.Rows[index].Cells["so_luong"].Value.ToString();
                string donViTinh = dataCT.Rows[index].Cells["DonViTinh"].Value.ToString();
                string giaNhap = dataCT.Rows[index].Cells["gia_nhap"].Value.ToString();
                frChiTietPN f = new frChiTietPN("Sua");
                f.GETVALUE(maHH, tenHH, soLuong, donViTinh, giaNhap);
                f.mydata = new frChiTietPN.GETDATA(EDITVALUE);
                f.ShowDialog(); // Sử dụng ShowDialog để đợi cho đến khi Form2 đóng lại
              
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
                LoadCongNo() ;
            }
        }

        private void btnXoaHetCT_Click(object sender, EventArgs e)
        {
            dataCT.Rows.Clear();
            LoadTongTien();
            LoadCongNo();
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
            frThanhToanPN f_ThanhToanPN = new frThanhToanPN(lblCongNo.Text);
            f_ThanhToanPN.mydata = new frThanhToanPN.GETDATA(ThanhToan);
            f_ThanhToanPN.ShowDialog();
            if (f_ThanhToanPN.isAgree)
            {
                SaveData();
                frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
                f_MessgaesSuccess.messages = "Luu phieu nhap thanh cong";
                f_MessgaesSuccess.ShowDialog();
                ResetForm();
                doiTrangThai();
            }
            
        }

        public void ThanhToan(string tienThanhToan)
        {
            int tienThanhToanInt = Convert.ToInt32(tienThanhToan);
            string congNoString = lblCongNo.Text.Replace(".", "").Replace(" VNĐ", "");
            int congNoInt = Convert.ToInt32(congNoString);
            int congNoMoi = congNoInt - tienThanhToanInt;
            lblCongNo.Text = congNoMoi.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ"; ;
        }

       
        
        private void SaveData()
        {
            //xử lý dữ liệu lưu vào các bảng ở databse
            string maPN = tbMaPN.Text;
            string maNCC = cbMaNCC.Text;
            string maNV = cbMaNV.Text;
            DateTime tg = DateTime.ParseExact(lblNgayNhap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngayNhap = tg.ToString("yyyy/MM/dd");

            //xử lý data và lưu vào bảng PHIEUNHAP
            sql = "INSERT INTO PHIEUNHAP (MaPN, MaNCC, MaNV, NgayNhap, TongTien) VALUES ('" + maPN + @"', '" + maNCC + @"','" + maNV + @"','" + ngayNhap + @"', '" + tongTien + @"')";
            db.changeData(sql);

            //xử lý data và lưu vào bảng NHACUNGCAP
            string congNo = lblCongNo.Text.Replace(".", "").Replace(" VNĐ", "");
            sql = "UPDATE NHACUNGCAP SET CongNo = '"+congNo+ @"' WHERE MaNCC = '"+cbMaNCC.Text+@"' ";
            db.changeData(sql);


            //xử lý data và lưu vào bảng CT_PHIEUNHAP và bảng HANGHOA
            foreach (DataGridViewRow row in dataCT.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maHH = row.Cells["ma_hh"].Value.ToString();
                    string soLuongN = row.Cells["so_luong"].Value.ToString();
                    string soLuong = soLuongN.Replace(".", "").Replace(" VNĐ", "");
                    string giaNhap = row.Cells["gia_nhap"].Value.ToString().Replace(".", "").Replace(" VNĐ", "");
                    // Lấy giá trị từ các cột khác tương tự ở đây
                    sql = "SELECT SoLuongTrongKho FROM HANGHOA WHERE MaHH = '" + maHH + @"'";
                    int soLuongCu = Convert.ToInt32(db.selectData(sql));
                    int soLuongMoi = soLuongCu + Convert.ToInt32(soLuong);
                    sql = "UPDATE HANGHOA SET SoluongTrongKho = '"+soLuongMoi+ @"' WHERE MaHH = '" + maHH + @"'";
                    db.changeData(sql);
                    sql = "INSERT INTO CT_PHIEUNHAP (MaPN, MaHH, SoLuong, GiaNhap) VALUES ('" + maPN + @"', '" + maHH + @"','" + soLuong + @"','" + giaNhap + @"')";
                    db.changeData(sql);
                }
            }
        }

        private void ResetForm()
        {
            tbMaPN.Text = string.Empty;
            cbMaNCC.Text = string.Empty;
            cbMaNV.Text = string.Empty;
            dataCT.Rows.Clear();
            LoadTongTien();
            lblCongNo.Text = "0 VNĐ";

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
