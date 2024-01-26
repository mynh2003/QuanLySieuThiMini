using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucNhaKho : UserControl
    {
        public ucNhaKho()
        {
            InitializeComponent();
            
            comboControls.SelectedItem = "Nhap hang vao kho";

            ucPhieuNhap uc_PhieuNhap = new ucPhieuNhap();
            addControlsToPanel(uc_PhieuNhap);
        }
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnControls.Controls.Clear();
            pnControls.Controls.Add(c);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboControls.SelectedItem.ToString();

            if (selectedValue == "Nhap hang vao kho")
            {
                ucPhieuNhap uc_PhieuNhap = new ucPhieuNhap();
                addControlsToPanel(uc_PhieuNhap);
            }
            else if (selectedValue == "Xuat hang ra quay")
            {
                ucPhieuXuat uc_PhieuXuat = new ucPhieuXuat();
                addControlsToPanel(uc_PhieuXuat);
            }
            else
            {
                ucDSHangCanNhap uc_DSHangCanNhap = new ucDSHangCanNhap();
                addControlsToPanel(uc_DSHangCanNhap);
            }
        }
    }
}
