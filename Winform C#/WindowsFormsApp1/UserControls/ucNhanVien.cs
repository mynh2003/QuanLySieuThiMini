using ClosedXML.Excel;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        DbConnection db = new DbConnection();
        string sql;
        string gioiTinh;
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataNhanVien.Rows.Clear();
            
            sql = "SELECT * FROM NHANVIEN";
            DataTable dt =  db.readData(sql);
            TruyenGiaTri(dt);
            
        }
        private void TruyenGiaTri(DataTable dt)
        {
            int stt = 0;
            foreach (DataRow row in dt.Rows)
            {
                stt++;
                string column1Value = stt.ToString();
                // Lấy giá trị từ các cột trong DataTable
                string column2Value = row[0].ToString();
                string column3Value = row[1].ToString();
                string column4Value;
                if (row[2].ToString() == "True")
                {
                    column4Value = "Nam";
                }
                else
                {
                    column4Value = "Nữ";

                }
                string column5Value = row[3].ToString();
                string column6Value = row[4].ToString();
                string column7Value = row[5].ToString();
                string column8Value = row[6].ToString();
                string column9Value = row[7].ToString();

                // ...

                // Thêm hàng mới vào DataGridView và truyền giá trị vào các ô tương ứng
                dataNhanVien.Rows.Add(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value, column9Value);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaNV.Text) ||
            string.IsNullOrWhiteSpace(tbTenNV.Text) ||
            string.IsNullOrWhiteSpace(tbQueQuan.Text) ||
            string.IsNullOrWhiteSpace(tbSDT.Text) ||
            string.IsNullOrWhiteSpace(tbViTriLamViec.Text) ||
            string.IsNullOrWhiteSpace(tbTaiKhoan.Text) ||
            string.IsNullOrWhiteSpace(tbMatKhau.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            if (!rbNam.Checked && !rbNu.Checked)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long chon gioi tinh";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maNV = tbMaNV.Text;
            string taiKhoan = tbTaiKhoan.Text;
            bool TonTaiMaNV = KiemTraTonTai("MaNV", maNV);
            bool TonTaiTaiKhoan = KiemTraTonTai("TaiKhoan", taiKhoan);
            if (TonTaiMaNV == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma nhan vien da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            if (TonTaiTaiKhoan == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Tai khoan da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            bool gioiTinh;
            if (rbNam.Checked)
            {
                gioiTinh = true;
            }
            else
            {
                gioiTinh = false;
            }

            sql = $"INSERT INTO NHANVIEN(MaNV, TenNV, GioiTinh, QueQuan, SDT, ViTriLamViec, TaiKhoan, MatKhau)" +
                $"VALUES ('" + tbMaNV.Text + @"',N'" + tbTenNV.Text + @"','" + gioiTinh + @"',N'" + tbQueQuan.Text + @"',
                '" + tbSDT.Text + @"',N'" + tbViTriLamViec.Text + @"','" + tbTaiKhoan.Text + @"','" + tbMatKhau.Text + @"')";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Them thong tin thanh cong";
            f_MessgaesSuccess.ShowDialog();
        }
        private bool KiemTraTonTai(string tenTruong, string giaTri)
        {
    
             sql = $"SELECT COUNT(*) FROM NHANVIEN WHERE {tenTruong} = N'"+giaTri+@"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
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
                sql = @"DELETE FROM NHANVIEN WHERE( MaNV ='" + tbMaNV.Text + @"')";
                db.changeData(sql);
                load();
                clearTB();
            }
        }
        public void clearTB()
        {
            tbMaNV.Clear();
            tbTenNV.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            tbQueQuan.Clear();
            tbSDT.Clear();
            tbViTriLamViec.Clear();
            tbTaiKhoan.Clear();
            tbMatKhau.Clear();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName = "DSNhanVien.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var worksheet = wb.Worksheets.Add("Danh sách nhân viên");

                            for (int i = 0; i < dataNhanVien.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataNhanVien.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataNhanVien.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataNhanVien.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataNhanVien.Rows[i].Cells[j].Value.ToString();
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


        private void dataNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã click vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dataNhanVien.Rows[e.RowIndex]; // Lấy dòng được click

                // Lấy giá trị từ các ô trong dòng và gán vào các textbox tương ứng
                tbMaNV.Text = row.Cells["MaNV"].Value.ToString();
                tbTenNV.Text = row.Cells["TenNV"].Value.ToString();
                if (row.Cells["GT"].Value.ToString() == "Nam")
                {
                    rbNam.Checked = true;
                }
                else
                {
                    rbNu.Checked = true;
                }
                tbQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                tbSDT.Text = row.Cells["SDT"].Value.ToString();
                tbViTriLamViec.Text = row.Cells["ViTriLamViec"].Value.ToString();
                tbTaiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                tbMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaNV.Text) ||
           string.IsNullOrWhiteSpace(tbTenNV.Text) ||          
           string.IsNullOrWhiteSpace(tbQueQuan.Text) ||
           string.IsNullOrWhiteSpace(tbSDT.Text) ||
           string.IsNullOrWhiteSpace(tbViTriLamViec.Text) ||
           string.IsNullOrWhiteSpace(tbTaiKhoan.Text) ||
           string.IsNullOrWhiteSpace(tbMatKhau.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            if (!rbNam.Checked && !rbNu.Checked)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long chon gioi tinh";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maNV = tbMaNV.Text;
            bool TonTaiMaNV = KiemTraTonTai("MaNV", maNV);    
            if (TonTaiMaNV == false)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma nhan vien khong ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }
            db.OpenConn();
            sql = $"SELECT TaiKhoan FROM NHANVIEN WHERE (MaNV <> N'" + tbMaNV.Text + @"' )";
            DataTable dt = db.readData(sql);
            foreach(DataRow row in dt.Rows)
            {
                string taiKhoan = row[0].ToString();
                if (tbTaiKhoan.Text == taiKhoan)
                {
                    // Giá trị trùng lặp được tìm thấy

                    frMessagesError f_MessgaesBox = new frMessagesError();
                    f_MessgaesBox.messages = "Tai khoan da ton tai";
                    f_MessgaesBox.ShowDialog();
                    return;
                }
            }


            bool gioiTinh;
            if (rbNam.Checked)
            {
                gioiTinh = true;
            }
            else
            {
                gioiTinh = false;
            }

            sql = $"UPDATE  NHANVIEN SET MaNV = N'" + tbMaNV.Text + @"', TenNV = N'" + tbTenNV.Text + @"' , GioiTinh = N'" + gioiTinh + @"', 
                QueQuan = N'" + tbQueQuan.Text + @"', SDT = N'" + tbSDT.Text + @"', ViTriLamViec = N'" + tbViTriLamViec.Text + @"', TaiKhoan = N'" + tbTaiKhoan.Text + @"', MatKhau = N'" + tbMatKhau.Text + @"'
                WHERE (MaNV = N'" + tbMaNV.Text + @"' )";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Sua thong tin nhan vien "+tbMaNV.Text +"\nthanh cong";
            f_MessgaesSuccess.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = tbTimKiem.Text;
            string gioiTinh = tbTimKiem.Text.ToLower();
            if (gioiTinh == "nam" || gioiTinh == "nữ" || gioiTinh == "nu" || gioiTinh == "nư")
            {
                if (gioiTinh == "nam") { gioiTinh = "flase"; }
                else { gioiTinh = "true"; }
            }
            sql = "SELECT * FROM NHANVIEN WHERE MaNV LIKE '%" + searchText + "%' OR TenNV LIKE N'%" + searchText + "%' OR GioiTinh LIKE '%" + gioiTinh + "%' OR QueQuan LIKE '%" + searchText + "%' " +
                "OR SDT LIKE '%" + searchText + "%' OR ViTriLamViec LIKE '%" + searchText + "%' OR TaiKhoan LIKE '%" + searchText + "%' OR MatKhau LIKE '%" + searchText + "%' ";
            DataTable dt = db.readData(sql);
            dataNhanVien.Rows.Clear();
            TruyenGiaTri(dt);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
            load();
        }
    }
}
