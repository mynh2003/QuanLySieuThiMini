using ClosedXML.Excel;
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
    public partial class ucDSHangCanNhap : UserControl
    {
        DbConnection db = new DbConnection();
        string sql;
        public ucDSHangCanNhap()
        {
            InitializeComponent();
        }

        private void ucDSHangCanNhap_Load(object sender, EventArgs e)
        {

        }

        private void tbDieuKien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadData()
        {
            dataHH.Rows.Clear();
            sql = "SELECT * FROM HANGHOA WHERE (SoLuongTrongKho + SoLuongNgoaiQuay) <= '" + tbDieuKien.Text + @"'";
            DataTable dt = db.readData(sql);

            int stt = 0;
            foreach(DataRow row in dt.Rows)
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
                dataHH.Rows.Add(stt, maHH, tenHH, soLuongTKN, soLuongNQN, donViTinh, hSD, noiSX);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName = "DSHangHoaCanNhap.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var worksheet = wb.Worksheets.Add("Danh sách hàng hóa cần nhập");

                            for (int i = 0; i < dataHH.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataHH.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dataHH.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataHH.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataHH.Rows[i].Cells[j].Value.ToString();
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
    }
}
