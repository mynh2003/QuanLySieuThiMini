using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;
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
    public partial class ucChiaCaNV : UserControl
    {
        DbConnection db = new DbConnection();
        
        public ucChiaCaNV()
        {
            InitializeComponent();
            
        }
       
        private void ucChiaCaNV_Load(object sender, EventArgs e)
        {
            LoadCbNam();
      

            LoadDataChiaCa();

            //đưa data và cbNVK
            string sql = "SELECT MaNV FROM NHANVIEN WHERE ViTriLamViec = 'Kho' ORDER  BY MaNV ASC ";
            DataTable dt_NVK;
            dt_NVK = db.readData(sql);
            List<string> ListNVK = new List<string>();
            foreach (DataRow row in dt_NVK.Rows)
            {
                ListNVK.Add(row[0].ToString());
            }
            cbNVK.Items.AddRange(ListNVK.ToArray());

            //đưa data và cbNVTN
            sql = "SELECT MaNV FROM NHANVIEN WHERE ViTriLamViec = 'Thu Ngân' ORDER  BY MaNV ASC ";
            DataTable dt_NVTN;
            dt_NVTN = db.readData(sql);
            List<string> ListNVTN = new List<string>();
            foreach (DataRow row in dt_NVTN.Rows)
            {
                ListNVTN.Add(row[0].ToString());
            }
            cbNVTN.Items.AddRange(ListNVTN.ToArray());

        }
        private void LoadCbNam()
        {
            int nam = DateTime.Now.Year;
            cbNam.Items.Add(nam + 1);
            cbNam.Items.Add(nam);
            cbNam.Items.Add(nam - 1);
            cbNam.SelectedIndex = 1;
        }
        public void LoadDataChiaCa()
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
                stt++;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtNgay.Text) ||
           string.IsNullOrWhiteSpace(cbThuTuCa.Text) ||
           string.IsNullOrWhiteSpace(cbNVK.Text) ||
           string.IsNullOrWhiteSpace(tbTenNVK.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string ngay = dtNgay.Value.ToString("yyyy/MM/dd");
            string thuTuCa = cbThuTuCa.Text;
            bool tonTaiCa = KiemTraTonTai(ngay, thuTuCa);
            if (tonTaiCa == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ca nhan vien da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string sql = $"INSERT INTO CANHANVIEN(Ngay, ThuTuCa, NhanVienKho, TrangThaiNVKho, NhanVienThuNgan, TrangThaiNVThuNgan)" +
                $"VALUES (N'" + dtNgay.Value.ToString("yyyy/MM/dd") + @"','" + cbThuTuCa.Text + @"','" + cbNVK.Text + @"','" + false + @"','" + cbNVTN.Text + @"','" + false + @"')";
            db.changeData(sql);

            LoadDataChiaCa();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Them ca thanh cong";
            f_MessgaesSuccess.ShowDialog();
        }
        private bool KiemTraTonTai(string ngay, string thuTuCa)
        {

            string sql = $"SELECT COUNT(*) FROM CANHANVIEN WHERE Ngay = '" + ngay + @"' AND ThuTuCa = '" + thuTuCa + @"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        private void dataChiaCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã click vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dataChiaCa.Rows[e.RowIndex]; // Lấy dòng được click

                // Lấy giá trị từ các ô trong dòng và gán vào các textbox tương ứng
                dtNgay.Value = Convert.ToDateTime(row.Cells["Ngay"].Value) ;      
                cbThuTuCa.Text = row.Cells["ThuTuCa"].Value.ToString();
                cbNVK.Text = row.Cells["NVKho"].Value.ToString();
                cbNVTN.Text = row.Cells["NVThuNgan"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(dtNgay.Text) ||
           string.IsNullOrWhiteSpace(cbThuTuCa.Text) ||
           string.IsNullOrWhiteSpace(cbNVK.Text) ||
           string.IsNullOrWhiteSpace(tbTenNVK.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string ngay = dtNgay.Value.ToString("yyyy/MM/dd");
            string thuTuCa = cbThuTuCa.Text;
            bool tonTaiCa = KiemTraTonTai(ngay, thuTuCa);
            if (tonTaiCa == false)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ca nhan vien khong ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string sql = $"UPDATE CANHANVIEN SET Ngay ='" + dtNgay.Value.ToString("yyyy/MM/dd") + @"',ThuTuCa ='" + cbThuTuCa.Text + @"',NhanVienKho ='" + cbNVK.Text + @"',TrangThaiNVKho='" + false + @"',NhanVienThuNgan ='" + cbNVTN.Text + @"',TrangThaiNVThuNgan='" + false + @"'
                            WHERE Ngay ='" + dtNgay.Value.ToString("yyyy/MM/dd") + @"' AND ThuTuCa ='" + cbThuTuCa.Text + @"' ";
            db.changeData(sql);

            LoadDataChiaCa();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Sua thong tin thanh cong";
            f_MessgaesSuccess.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frMessagesWarring f_MessagesWarring = new frMessagesWarring();
            f_MessagesWarring.messages = "Ban co muon xoa ban ghi nay khong?";
            f_MessagesWarring.ShowDialog();

            //Kiểm tra xem có dòng nào được chọn không
            if (f_MessagesWarring.isAgree)
            {

                db.OpenConn();
                string sql = @"DELETE FROM CANHANVIEN WHERE Ngay ='" + dtNgay.Value.ToString("yyyy/MM/dd") + @"' AND ThuTuCa ='" + cbThuTuCa.Text + @"' ";
                db.changeData(sql);
                LoadDataChiaCa();
                ClearTB();
            }
        }
        public void ClearTB()
        {
            dtNgay.Value = DateTime.Now;
            cbThuTuCa.Text = null;
            cbNVK.Text = null;
            tbTenNVK.Clear();
            cbNVTN.Text = null;
            tbTenNVTN.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTB();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName = "DSChiaCa.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var worksheet = wb.Worksheets.Add("Danh sách chia ca");

                            for (int i = 0; i < dataChiaCa.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataChiaCa.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataChiaCa.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataChiaCa.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataChiaCa.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            wb.SaveAs(sfd.FileName); // Lưu workbook với tên và đường dẫn đã chọn
                            MessageBox.Show("Xuất file excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        frMessagesError f_MessgaesBox = new frMessagesError();
                        f_MessgaesBox.messages = ex.Message;
                        f_MessgaesBox.ShowDialog();
                    }
                }
            }
        }

        private void cbNVK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNVK.Text == "")
            {
                return;
            }
            string sql = "SELECT TenNV FROM NHANVIEN WHERE MaNV='" + cbNVK.Text + @"'";
            tbTenNVK.Text = db.selectData(sql);
        }

        private void cbNVTN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNVTN.Text == "")
            {
                return;
            }
            string sql = "SELECT TenNV FROM NHANVIEN WHERE MaNV='" + cbNVTN.Text + @"'";
            tbTenNVTN.Text = db.selectData(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(cbThang.Text == "")
            {
                string nam = cbNam.Text; 
                string sql = "SELECT * FROM CANHANVIEN WHERE YEAR(Ngay) ='" + nam + @"'";
                dt = db.readData(sql);
            }
            else if(cbNam.Text == "")
            {
                string thang = cbThang.Text;
                string sql = "SELECT * FROM CANHANVIEN WHERE  MONTH(Ngay) ='" + thang + @"' ";
                dt = db.readData(sql);
            }
            else
            {
                string nam = cbNam.Text;
                string thang = cbThang.Text;
                string sql = "SELECT * FROM CANHANVIEN WHERE YEAR(Ngay) ='" + nam + @"' AND MONTH(Ngay) ='" + thang + @"' ";
                dt = db.readData(sql);
            }
            
            dataChiaCa.Rows.Clear();
            TruyenGiaTri(dt);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbNam.Text = null;
            cbThang.Text = null;
            LoadDataChiaCa();
        }
    }
}
