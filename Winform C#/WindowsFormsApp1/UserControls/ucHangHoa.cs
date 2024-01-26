using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class ucHangHoa : UserControl
    {
        DbConnection db = new DbConnection();
        string sql;
        public ucHangHoa()
        {
            InitializeComponent();
        }

        private void ucHangHoa_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            dataHangHoa.Rows.Clear();

            sql = "SELECT * FROM HANGHOA;";
            DataTable dt = db.readData(sql);

            TruyenGiaTri(dt);
            
        }
        private void TruyenGiaTri(DataTable dt)
        {
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
                dataHangHoa.Rows.Add(stt, maHH, tenHH, soLuongTKN, soLuongNQN, donViTinh, hSD, noiSX);
            }
        }
     
        private bool KiemTraTonTai(string tenTruong, string giaTri)
        {

            sql = $"SELECT COUNT(*) FROM HANGHOA WHERE {tenTruong} = N'" + giaTri + @"'";
            DataTable dt = db.readData(sql);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                return true;
            }

            return false;
        }

        private void dataHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã click vào một dòng hợp lệ hay không
            {
                DataGridViewRow row = dataHangHoa.Rows[e.RowIndex]; // Lấy dòng được click

                // Lấy giá trị từ các ô trong dòng và gán vào các textbox tương ứng
                tbMaHH.Text = row.Cells["MaHH"].Value.ToString();
                tbTenHH.Text = row.Cells["TenHH"].Value.ToString();
                tbDonViTinh.Text = row.Cells["DonVitinh"].Value.ToString();
                tbSLTK.Text = row.Cells["SoLuongTrongKho"].Value.ToString();
                tbSLNQ.Text = row.Cells["SoLuongNgoaiQuay"].Value.ToString();
                tbHSD.Text = row.Cells["HSD"].Value.ToString();
                tbNSX.Text = row.Cells["NoiSX"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbMaHH.Text) ||
            string.IsNullOrWhiteSpace(tbTenHH.Text) ||
            string.IsNullOrWhiteSpace(tbDonViTinh.Text) ||
            string.IsNullOrWhiteSpace(tbSLTK.Text) ||
            string.IsNullOrWhiteSpace(tbSLNQ.Text) ||
            string.IsNullOrWhiteSpace(tbHSD.Text) ||
            string.IsNullOrWhiteSpace(tbNSX.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }
            string maHH = tbMaHH.Text;
            bool TonTaiMaHH = KiemTraTonTai("MaHH", maHH);
            if (TonTaiMaHH == true)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma hang hoa da ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }

          
            sql = $"INSERT INTO HANGHOA " +
                $"VALUES ('" + tbMaHH.Text + @"',N'" + tbTenHH.Text + @"','" + tbSLTK.Text.Replace(".", "") + @"','" + tbSLNQ.Text.Replace(".", "") + @"',
                N'" + tbDonViTinh.Text + @"',N'" + tbHSD.Text + @"', N'" + tbNSX.Text + @"' )";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Them thong tin thanh cong";
            f_MessgaesSuccess.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaHH.Text) ||
            string.IsNullOrWhiteSpace(tbTenHH.Text) ||
            string.IsNullOrWhiteSpace(tbDonViTinh.Text) ||
            string.IsNullOrWhiteSpace(tbSLTK.Text) ||
            string.IsNullOrWhiteSpace(tbSLNQ.Text) ||
            string.IsNullOrWhiteSpace(tbHSD.Text) ||
            string.IsNullOrWhiteSpace(tbNSX.Text))
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Vui long nhap day du thong tin";
                f_MessgaesBox.ShowDialog();
                return;
            }

            string maHH = tbMaHH.Text;
            bool TonTaiMaHH = KiemTraTonTai("MaHH", maHH);
            if (TonTaiMaHH == false)
            {
                frMessagesError f_MessgaesBox = new frMessagesError();
                f_MessgaesBox.messages = "Ma hang hoa khong ton tai";
                f_MessgaesBox.ShowDialog();
                return;
            }

            sql = $"UPDATE  HANGHOA SET MaHH = N'" + tbMaHH.Text + @"', TenHH = N'" + tbTenHH.Text + @"' , 
                DonViTinh = N'" + tbDonViTinh.Text + @"', SoLuongTrongKho = N'" + tbSLTK.Text.Replace(".", "") + @"', SoLuongNgoaiQuay = N'" + tbSLNQ.Text.Replace(".", "") + @"' ,
                HSD = N'" + tbHSD.Text + "' ,NoiSX = N'" + tbNSX.Text + @"' 
                WHERE (MaHH = N'" + tbMaHH.Text + @"' )";
            db.changeData(sql);

            load();
            frMessagesSuccess f_MessgaesSuccess = new frMessagesSuccess();
            f_MessgaesSuccess.messages = "Sua thong tin hang hoa " + tbMaHH.Text + "\nthanh cong";
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
                sql = @"DELETE FROM HANGHOA WHERE( MaHH ='" + tbMaHH.Text + @"')";
                db.changeData(sql);
                load();
                clearTB();
            }
        }
        public void clearTB()
        {
            tbMaHH.Clear();
            tbTenHH.Clear();
            tbDonViTinh.Clear();
            tbSLTK.Clear();
            tbSLNQ.Clear();
            tbHSD.Clear();
            tbNSX.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTB();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName = "DSHangHoa.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            // Tạo một worksheet trong workbook
                            var worksheet = wb.Worksheets.Add("Danh Sách Hàng Hóa");

                            // Lấy dữ liệu từ DataGridView
                            for (int i = 0; i < dataHangHoa.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataHangHoa.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataHangHoa.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataHangHoa.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataHangHoa.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                            wb.SaveAs(sfd.FileName);
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


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = tbTimKiem.Text;
            sql = "SELECT * FROM HANGHOA WHERE MaHH LIKE '%" + searchText + "%' OR TenHH LIKE N'%" + searchText + "%' OR DonViTinh LIKE '%" + searchText + "%' OR SoLuongTrongKho LIKE '%" + searchText + "%' " +
                "OR SoLuongNgoaiQuay LIKE '%" + searchText + "%' OR  HSD LIKE '%" + searchText + "%' OR NoiSX LIKE N'%" + searchText + "%'";
            DataTable dt = db.readData(sql);
            dataHangHoa.Rows.Clear();
            TruyenGiaTri(dt);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
            load();
        }
        private void tbSLTK_TextChanged(object sender, EventArgs e)
        {

            if (tbSLTK.Text.Length > 13)
            {

                tbSLTK.Text = tbSLTK.Text.Substring(0, 13);
                tbSLTK.Select(tbSLTK.Text.Length, 0);
            }
            else
            {
                tbSLTK.Text = FormatNumberToVND(tbSLTK.Text.Replace(".", ""));
                tbSLTK.Select(tbSLTK.Text.Length, 0);
            }

        }
        private void tbSLNQ_TextChanged(object sender, EventArgs e)
        {

            if (tbSLNQ.Text.Length > 13)
            {

                tbSLNQ.Text = tbSLNQ.Text.Substring(0, 13);
                tbSLNQ.Select(tbSLNQ.Text.Length, 0);
            }
            else
            {
                tbSLNQ.Text = FormatNumberToVND(tbSLNQ.Text.Replace(".", ""));
                tbSLNQ.Select(tbSLNQ.Text.Length, 0);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
