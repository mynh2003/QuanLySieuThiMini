using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucNCC : UserControl
    {
        DbConnection db = new DbConnection();
        string sql;

        private Dictionary<TextBox, int> viTri = new Dictionary<TextBox, int>();

        public ucNCC()
        {
            InitializeComponent();

        }
        private void ucNCC_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataNCC.Rows.Clear();

            sql = "SELECT * FROM NHACUNGCAP";
            DataTable dt = db.readData(sql);
            TruyenGiaTri(dt);
        }
        private void TruyenGiaTri(DataTable dt)
        {
            int stt = 0;
            foreach (DataRow row in dt.Rows)
            {
                stt++;
                string column1Value = stt.ToString();
                string column2Value = row[0].ToString();
                string column3Value = row[1].ToString();
                string column4Value = row[2].ToString();
                string column5Value = row[3].ToString();
                string column6Value = row[4].ToString();
                string congNo = Convert.ToDecimal(column6Value).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";

                dataNCC.Rows.Add(column1Value, column2Value, column3Value, column4Value, column5Value, congNo);
            }
        }

            private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbMaNCC.Text) ||
            string.IsNullOrWhiteSpace(tbTenNCC.Text) ||
            string.IsNullOrWhiteSpace(tbDiaChi.Text) ||
            string.IsNullOrWhiteSpace(tbSDT.Text) ||
            string.IsNullOrWhiteSpace(tbCongNo.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maNCC = tbMaNCC.Text;
            bool TonTaiMaNCC = KiemTraTonTai("MaNCC", maNCC);
            if (TonTaiMaNCC == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma nha cung cap da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }

            sql = $"INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SDT, CongNo)" +
                $"VALUES ('" + tbMaNCC.Text + @"',N'" + tbTenNCC.Text + @"',N'" + tbDiaChi.Text + @"',
                '" + tbSDT.Text + @"','" + tbCongNo.Text.Replace(".", "") + @"')";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Them thong tin thanh cong";
            f_MessgaesSuccess.ShowDialog();
        }
        private bool KiemTraTonTai(string tenTruong, string giaTri)
        {

            sql = $"SELECT COUNT(*) FROM NHACUNGCAP WHERE {tenTruong} = N'" + giaTri + @"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        private void dataNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã click vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dataNCC.Rows[e.RowIndex]; // Lấy dòng được click

                // Lấy giá trị từ các ô trong dòng và gán vào các textbox tương ứng
                tbMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                tbTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                tbSDT.Text = row.Cells["SDT"].Value.ToString();
                tbCongNo.Text = row.Cells["CongNo"].Value.ToString().Replace(" VNĐ", "");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaNCC.Text) ||
           string.IsNullOrWhiteSpace(tbTenNCC.Text) ||
           string.IsNullOrWhiteSpace(tbDiaChi.Text) ||
           string.IsNullOrWhiteSpace(tbSDT.Text) ||
           string.IsNullOrWhiteSpace(tbCongNo.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }

            string maNCC = tbMaNCC.Text;
            bool TonTaiMaNCC = KiemTraTonTai("MaNCC", maNCC);
            if (TonTaiMaNCC == false)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma nha cung cap khong ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }

            sql = $"UPDATE  NHACUNGCAP SET MaNCC = N'" + tbMaNCC.Text + @"', TenNCC = N'" + tbTenNCC.Text + @"' , 
                DiaChi = N'" + tbDiaChi.Text + @"', SDT = N'" + tbSDT.Text + @"', CongNo = N'" + tbCongNo.Text.Replace(".", "") + @"'
                WHERE (MaNCC = N'" + tbMaNCC.Text + @"' )";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Sua thong tin nha cung cap " + tbMaNCC.Text + "\nthanh cong";
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
                sql = @"DELETE FROM NHACUNGCAP WHERE( MaNCC ='" + tbMaNCC.Text + @"')";
                db.changeData(sql);
                load();
                clearTB();
            }
        }
        public void clearTB()
        {
            tbMaNCC.Clear();
            tbTenNCC.Clear();
            tbDiaChi.Clear();
            tbSDT.Clear();
            tbCongNo.Clear();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName="DSNhaCungCap.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            // Tạo một worksheet trong workbook
                            var worksheet = wb.Worksheets.Add("Danh sách nhà cung cấp");

                            // Lấy dữ liệu từ DataGridView
                            for (int i = 0; i < dataNCC.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataNCC.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataNCC.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataNCC.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataNCC.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            wb.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Xuất file excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void tbCongNo_TextChanged(object sender, EventArgs e)
        {

                if (tbCongNo.Text.Length > 13)
                {

                    tbCongNo.Text = tbCongNo.Text.Substring(0, 13);
                    tbCongNo.Select(tbCongNo.Text.Length, 0);
                }
                else
                {
                    tbCongNo.Text = FormatNumberToVND(tbCongNo.Text.Replace(".", ""));
                    tbCongNo.Select(tbCongNo.Text.Length, 0);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = tbTimKiem.Text;
            sql = "SELECT * FROM NHACUNGCAP WHERE MaNCC LIKE '%" + searchText + "%' OR TenNCC LIKE N'%" + searchText + "%' OR DiaChi LIKE '%" + searchText + "%' OR SDT LIKE '%" + searchText + "%' " +
                "OR CongNo LIKE '%" + searchText + "%' ";
            DataTable dt = db.readData(sql);
            dataNCC.Rows.Clear();
            TruyenGiaTri(dt);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
            load();
        }
    }
}
