using ClosedXML.Excel;
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
    public partial class ucThongKe : UserControl
    {
        DbConnection db = new DbConnection();
        public ucThongKe()
        {
            InitializeComponent();
        }
        private void ucThongKe_Load(object sender, EventArgs e)
        {
            rdNam.Checked = true;

            LoadCbNam();
            cbTuyChon.SelectedItem = "Hang da nhap";
        }
        private void LoadCbNam()
        {
            int nam = DateTime.Now.Year;
            cbNam.Items.Add(nam);
            cbNam.Items.Add(nam - 1);
            cbNam.SelectedIndex = 0;
        }
        private void LoadCbThang()
        {
            int nam = Convert.ToInt32(cbNam.SelectedItem);

            List<int> thangTrongNam = new List<int>();
            int namHienTai = DateTime.Now.Year;
            int thangHienTai = DateTime.Now.Month;

            if (nam == namHienTai)
            {
                // Nếu năm được chọn là năm hiện tại, thì chỉ thêm các tháng đến tháng hiện tại
                for (int i = 1; i <= thangHienTai; i++)
                {
                    thangTrongNam.Add(i);
                }
            }
            else
            {
                // Nếu năm được chọn không phải là năm hiện tại, thì thêm tất cả các tháng
                for (int i = 1; i <= 12; i++)
                {
                    thangTrongNam.Add(i);
                }
            }

            // Gán danh sách các tháng vào cbThang
            cbThang.DataSource = thangTrongNam;
        }
        private void LoadCbNgay()
        {
            int nam = Convert.ToInt32(cbNam.SelectedItem);
            int thang = Convert.ToInt32(cbThang.SelectedItem);

            // Tạo danh sách các ngày tương ứng với năm và tháng được chọn
            List<int> ngayTrongThang = new List<int>();
            int namHienTai = DateTime.Now.Year;
            int thangHienTai = DateTime.Now.Month;
            int ngayHienTai = DateTime.Now.Day;

            if (nam == namHienTai && thang == thangHienTai)
            {
                // Nếu năm và tháng được chọn là năm và tháng hiện tại, thì chỉ thêm các ngày đến ngày hiện tại
                for (int i = 1; i <= ngayHienTai; i++)
                {
                    ngayTrongThang.Add(i);
                }
            }
            else
            {
                // Nếu năm và tháng được chọn không phải là năm và tháng hiện tại, thì thêm tất cả các ngày trong tháng
                int daysInSelectedMonth = DateTime.DaysInMonth(nam, thang);
                for (int i = 1; i <= daysInSelectedMonth; i++)
                {
                    ngayTrongThang.Add(i);
                }
            }

            // Gán danh sách các ngày vào cbNgay
            cbNgay.DataSource = ngayTrongThang;
        }
        private void cbTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTuyChon.SelectedItem == "Hang da nhap")
            {
                rdNam.Checked = true;
                LoadDataHTHangNhap();
            }
            else if (cbTuyChon.SelectedItem == "Hang da ban")
            {
                rdNam.Checked = true;
                LoadDataHTHangBan();
            }
            else
            {
                rdNam.Checked = false;
                rdThang.Checked = false;
                rdNgay.Checked = false;
                cbNam.Text = null;
                grThongKe.Enabled = false;
                btnXuat.Enabled = false;
                LoadDataHTHangTon();
            }
        }
        private void LoadDataHTHangNhap()
        {
            DataTable dt = new DataTable();
            List<HangNhap> list = new List<HangNhap>();
            string sql;
            if (rdNam.Checked == true && rdThang.Checked == false && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) = '" + nam + @"'";
                dt = db.readData(sql);              
                foreach (DataRow row in dt.Rows)
                {
                    string maPN = row["MaPN"].ToString();
                    
                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_PHIEUNHAP WHERE MaPN ='" + maPN + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangNhap data = new HangNhap
                    {
                        MaPN = maPN,
                        MaNCC = row["MaNCC"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        NgayNhap = Convert.ToDateTime(row["NgayNhap"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }
            else if (rdNam.Checked == false && rdThang.Checked == true && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) ='" + nam + @"' AND MONTH(NgayNhap) ='" + thang + @"' ";
                dt = db.readData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string maPN = row["MaPN"].ToString();

                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_PHIEUNHAP WHERE MaPN ='" + maPN + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangNhap data = new HangNhap
                    {
                        MaPN = maPN,
                        MaNCC = row["MaNCC"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        NgayNhap = Convert.ToDateTime(row["NgayNhap"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }
            else
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                int ngay = Convert.ToInt32(cbNgay.SelectedItem);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) ='" + nam + @"' AND MONTH(NgayNhap) ='" + thang + @"' AND DAY(NgayNhap) ='" + ngay + @"'";
                dt = db.readData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string maPN = row["MaPN"].ToString();

                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_PHIEUNHAP WHERE MaPN ='" + maPN + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangNhap data = new HangNhap
                    {
                        MaPN = maPN,
                        MaNCC = row["MaNCC"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        NgayNhap = Convert.ToDateTime(row["NgayNhap"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }


            if (dt.Columns.Count > 0)
            {
                dataHT.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
                dataHT.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataHT.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataHT.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dataHT.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataHT.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";

                LoadTongSoLuong("TongSoLuong");
            }
        }
        private void LoadDataHTHangBan()
        {
            DataTable dt = new DataTable();
            List<HangBan> list = new List<HangBan>();
            string sql;
            if (rdNam.Checked == true && rdThang.Checked == false && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"'";
                dt = db.readData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string maHD = row["MaHD"].ToString();
                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_HOADON WHERE MaHD ='" + maHD + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangBan data = new HangBan
                    {
                        MaHD = maHD,
                        MaNV = row["MaNV"].ToString(),
                        ThoiGianTao = Convert.ToDateTime(row["ThoiGianTao"].ToString()),
                        NgayTao = Convert.ToDateTime(row["NgayTao"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }
            else if (rdNam.Checked == false && rdThang.Checked == true && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"' AND MONTH(NgayTao) ='" + thang + @"' ";
                dt = db.readData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string maHD = row["MaHD"].ToString();
                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_HOADON WHERE MaHD ='" + maHD + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangBan data = new HangBan
                    {
                        MaHD = maHD,
                        MaNV = row["MaNV"].ToString(),
                        ThoiGianTao = Convert.ToDateTime(row["ThoiGianTao"].ToString()),
                        NgayTao = Convert.ToDateTime(row["NgayTao"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }
            else
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                int ngay = Convert.ToInt32(cbNgay.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"' AND MONTH(NgayTao) ='" + thang + @"' AND DAY(NgayTao) ='" + ngay + @"'";
                dt = db.readData(sql);
                foreach (DataRow row in dt.Rows)
                {
                    string maHD = row["MaHD"].ToString();
                    int tongSoLuong = 0;
                    sql = "SELECT SUM(SoLuong) FROM CT_HOADON WHERE MaHD ='" + maHD + @"'";
                    tongSoLuong = Convert.ToInt32(db.selectData(sql));
                    HangBan data = new HangBan
                    {
                        MaHD = maHD,
                        MaNV = row["MaNV"].ToString(),
                        ThoiGianTao = Convert.ToDateTime(row["ThoiGianTao"].ToString()),
                        NgayTao = Convert.ToDateTime(row["NgayTao"].ToString()),
                        TongTien = Convert.ToInt32(row["TongTien"].ToString()),
                        TongSoLuong = tongSoLuong,
                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;
            }


            if (dt.Columns.Count > 0)
            {
                dataHT.Columns["MaHD"].HeaderText = "Mã hóa đơn";      
                dataHT.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataHT.Columns["ThoiGianTao"].HeaderText = "Thời gian tạo";
                dataHT.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dataHT.Columns["TongTien"].HeaderText = "Tổng tiền";
                dataHT.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";

                LoadTongSoLuong("TongSoLuong");
            }
        }
        private void LoadDataHTHangTon()
        {
            string sql = "SELECT * FROM HANGHOA WHERE SoLuongTrongKho > 0";
            DataTable dt = db.readData(sql);
            dataHT.DataSource = dt;
            LoadTongSoLuong("SoLuongTrongKho");
        }
        private void LoadTongSoLuong(string tenCot)
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dataHT.Rows)
            {
                int tongLuong;
                if (row.Cells[tenCot].Value != null && int.TryParse(row.Cells[tenCot].Value.ToString(), out tongLuong))
                {
                    tongTien += tongLuong;
                }
            }
            lblTongTien.Text = tongTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
        }

        private void dataHT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(cbTuyChon.SelectedItem == "Hang ton kho")
            {
                if (e.ColumnIndex == 2)
                {
                    if (e.Value != null && e.Value is int)
                    {
                        e.Value = ((int)e.Value).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                        e.FormattingApplied = true;
                    }
                }
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    if (e.Value != null && e.Value is int)
                    {
                        e.Value = ((int)e.Value).ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                        e.FormattingApplied = true;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    if (e.Value != null && e.Value is int)
                    {
                        e.Value = ((int)e.Value).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {

            if (rdNgay.Checked)
            {
                cbNgay.Enabled = true;
                cbThang.Enabled = true;
                cbNam.Enabled = true;
            }
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {

            if (rdThang.Checked)
            {
                cbNgay.Enabled = false;
                cbThang.Enabled = true;
                cbNam.Enabled = true;
                cbNgay.Text = null;
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

            if (rdNam.Checked)
            {
                cbNgay.Enabled = false;
                cbThang.Enabled = false;
                cbNam.Enabled = true;
                cbNgay.Text = null;
                cbThang.Text = null;
            }
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.Enabled)
            {
                LoadCbThang();
            }

        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNgay.Enabled)
            {
                LoadCbNgay();
            }

        }

        private void cbThang_EnabledChanged(object sender, EventArgs e)
        {
            if (cbThang.Text != null)
            {
                LoadCbThang();
            }
        }

        private void cbNgay_EnabledChanged(object sender, EventArgs e)
        {
            if (cbNgay.Text != null)
            {
                LoadCbNgay();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (cbTuyChon.SelectedItem == "Hang da nhap")
            {
                LoadDataHTHangNhap();
            }
            else
            {
                LoadDataHTHangBan();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataHT.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx", FileName = cbTuyChon.SelectedItem + ".xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                var worksheet = wb.Worksheets.Add(cbTuyChon.SelectedItem.ToString());

                                for (int i = 0; i < dataHT.Columns.Count; i++)
                                {
                                    worksheet.Cell(1, i + 1).Value = dataHT.Columns[i].HeaderText;
                                }

                                for (int i = 0; i < dataHT.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataHT.Columns.Count; j++)
                                    {
                                        worksheet.Cell(i + 2, j + 1).Value = dataHT.Rows[i].Cells[j].Value.ToString();
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
}
