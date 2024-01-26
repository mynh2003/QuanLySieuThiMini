using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ChiTietPN
    {
        public int STT { get; set; }
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int ThanhTien
        {
            get
            {
                return SoLuong * GiaNhap;
            }
        }
    }
}
