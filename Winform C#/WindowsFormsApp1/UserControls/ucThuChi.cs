using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucThuChi : UserControl
    {
        DbConnection db = new DbConnection();
        
        public ucThuChi()
        {
            InitializeComponent();          
        }
        private void ucThuChi_Load(object sender, EventArgs e)
        {
            rdNam.Checked = true;
            
            LoadCbNam();
            cbTuyChon.SelectedItem = "Tien nhap hang";
        }

        private void LoadCbNam()
        {
            int nam = DateTime.Now.Year;
            cbNam.Items.Add(nam);
            cbNam.Items.Add(nam-1);
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
            if (cbTuyChon.SelectedItem == "Tien nhap hang")
            {
                rdNgay.Enabled = true;
                rdNam.Checked = true;
                LoadDataHTTienNhap();
            }
            else if (cbTuyChon.SelectedItem == "Tien ban hang")
            {
                rdNgay.Enabled = true;
                rdNam.Checked = true;
                LoadDataHTBanHang();
            }
            else
            {
                rdNgay.Enabled = false;
                rdNam.Checked = true;
                LoadDataHTTienLuong();
            }
        }
        private void LoadDataHTTienNhap()
        {
            DataTable dt = new DataTable();
            string sql;
            if (rdNam.Checked == true && rdThang.Checked == false && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.Text);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) ='" + nam + @"'";
                dt = db.readData(sql);
                dataHT.DataSource = dt;
            }
            else if (rdNam.Checked == false && rdThang.Checked == true && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) ='" + nam + @"' AND MONTH(NgayNhap) ='" + thang + @"' ";
                dt = db.readData(sql);
                dataHT.DataSource = dt;
            }
            else
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                int ngay = Convert.ToInt32(cbNgay.SelectedItem);
                sql = "SELECT * FROM PHIEUNHAP WHERE YEAR(NgayNhap) ='" + nam + @"' AND MONTH(NgayNhap) ='" + thang + @"' AND DAY(NgayNhap) ='" + ngay + @"'";
                dt = db.readData(sql);
                dataHT.DataSource = dt;
            }


            if(dt.Columns.Count > 0)
            {
                dataHT.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
                dataHT.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                dataHT.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataHT.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dataHT.Columns["TongTien"].HeaderText = "Tổng tiền";

                LoadTongTien("TongTien");
            }
            

        }
        private void LoadDataHTBanHang()
        {
            DataTable dt = new DataTable();
            string sql;
            if (rdNam.Checked == true && rdThang.Checked == false && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"'";
                dt = db.readData(sql);
                dataHT.DataSource = dt;

            }
            else if (rdNam.Checked == false && rdThang.Checked == true && rdNgay.Checked == false)
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"' AND MONTH(NgayTao) ='" + thang + @"' ";
                dt = db.readData(sql);
                dataHT.DataSource = dt;

            }
            else
            {
                int nam = Convert.ToInt32(cbNam.SelectedItem);
                int thang = Convert.ToInt32(cbThang.SelectedItem);
                int ngay = Convert.ToInt32(cbNgay.SelectedItem);
                sql = "SELECT * FROM HOADON WHERE YEAR(NgayTao) ='" + nam + @"' AND MONTH(NgayTao) ='" + thang + @"' AND DAY(NgayTao) ='" + ngay + @"'";
                dt = db.readData(sql);
                dataHT.DataSource = dt;
            }

            if (dt.Columns.Count > 0)
            {
                dataHT.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                dataHT.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataHT.Columns["ThoiGianTao"].HeaderText = "Thời gian tạo";
                dataHT.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dataHT.Columns["TongTien"].HeaderText = "Tổng tiền";

                LoadTongTien("TongTien");
            }
            

        }
        private void LoadDataHTTienLuong()
        {
            DataTable dt = new DataTable();
            string sql;
            if (rdNam.Checked == true && rdThang.Checked == false && rdNgay.Checked == false)
            {
                sql = "SELECT MaNV, TenNV FROM NHANVIEN";
                dt = db.readData(sql);
                List<BangLuong> list = new List<BangLuong>();
                foreach (DataRow row in dt.Rows)
                {

                    string maNV = row["MaNV"].ToString();
                    string tenNV = row["TenNV"].ToString();
                    int nam = Convert.ToInt32(cbNam.SelectedItem);
                    sql = "SELECT ViTriLamViec FROM NHANVIEN WHERE MaNV = '" + maNV + @"'";
                    int tongCa = 0;
                    if (db.selectData(sql) == "Kho")
                    {
                        sql = "SELECT COUNT(TrangThaiNVKho) FROM CANHANVIEN WHERE YEAR(Ngay) = '" + nam + @"' AND   NhanVienKho ='" + maNV + @"' AND TrangThaiNVKho = '" + true + @"'";
                        tongCa = Convert.ToInt32(db.selectData(sql));
                    }
                    else
                    {
                        sql = "SELECT COUNT(TrangThaiNVThuNgan) FROM CANHANVIEN WHERE YEAR(Ngay) = '" + nam + @"' AND   NhanVienThuNgan ='" + maNV + @"' AND TrangThaiNVThuNgan = '" + true + @"'";
                        tongCa = Convert.ToInt32(db.selectData(sql));
                    }

                    // Tạo đối tượng BangLuong và thêm vào danh sách
                    BangLuong data = new BangLuong
                    {
                        MaNV = maNV,
                        TenNV = tenNV,
                        TongCa = tongCa,
                        ThangNam = nam.ToString(),
                        TongLuong = tongCa * 75000,

                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true;
                dataHT.DataSource = list;

            }
            else
            {
                sql = "SELECT MaNV, TenNV FROM NHANVIEN";
                dt = db.readData(sql);
                List<BangLuong> list = new List<BangLuong>();
                foreach (DataRow row in dt.Rows)
                {
                    string maNV = row["MaNV"].ToString();
                    string tenNV = row["TenNV"].ToString();
                    int nam = Convert.ToInt32(cbNam.SelectedItem);
                    int thang = Convert.ToInt32(cbThang.SelectedItem);
                    string thangNam = thang + "/" + nam;
                    sql = "SELECT ViTriLamViec FROM NHANVIEN WHERE MaNV = '" + maNV + @"'";
                    int tongCa = 0;
                    if (db.selectData(sql) == "Kho")
                    {
                        sql = "SELECT COUNT(TrangThaiNVKho) FROM CANHANVIEN WHERE YEAR(Ngay) = '" + nam + @"' AND MONTH(Ngay) ='" + thang + @"' AND   NhanVienKho ='" + maNV + @"' AND TrangThaiNVKho = '" + true + @"'";
                        tongCa = Convert.ToInt32(db.selectData(sql));
                    }
                    else
                    {
                        sql = "SELECT COUNT(TrangThaiNVThuNgan) FROM CANHANVIEN WHERE YEAR(Ngay) = '" + nam + @"' AND MONTH(Ngay) ='" + thang + @"' AND   NhanVienThuNgan ='" + maNV + @"' AND TrangThaiNVThuNgan = '" + true + @"'";
                        tongCa = Convert.ToInt32(db.selectData(sql));
                    }


                    // Tạo đối tượng BangLuong và thêm vào danh sách
                    BangLuong data = new BangLuong
                    {
                        MaNV = maNV,
                        TenNV = tenNV,
                        TongCa = tongCa,
                        ThangNam = thangNam,
                        TongLuong = tongCa * 75000,

                    };
                    list.Add(data);
                }
                dataHT.AutoGenerateColumns = true; // Set AutoGenerateColumns to true if you want the columns to be generated automatically
                dataHT.DataSource = list;
            }
                
            if (dt.Rows.Count > 0)
            {
                    
                dataHT.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dataHT.Columns["TenNV"].HeaderText = "Tên nhân viên";
                dataHT.Columns["TongCa"].HeaderText = "Tổng ca";
                if (rdNam.Checked)
                {
                    dataHT.Columns["ThangNam"].HeaderText = "Năm";
                }
                else
                {
                    dataHT.Columns["ThangNam"].HeaderText = "Tháng năm";
                }
                dataHT.Columns["TongLuong"].HeaderText = "Tổng lương";

                LoadTongTien("TongLuong");
            }
            
        }

        private void LoadTongTien(string tenCot)
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
            lblTongTien.Text = tongTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
        }

        private void dataHT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null && e.Value is int)
                {
                    e.Value = ((int)e.Value).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " VNĐ";
                    e.FormattingApplied = true;
                }
            }
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rdNgay.Checked)
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
            if(cbThang.Text != null)
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
            if (cbTuyChon.SelectedItem == "Tien nhap hang")
            {
                LoadDataHTTienNhap();
            }
            else if (cbTuyChon.SelectedItem == "Tien ban hang")
            {
                LoadDataHTBanHang();
            }
            else
            {
                LoadDataHTTienLuong();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(dataHT.Rows.Count > 0)
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
