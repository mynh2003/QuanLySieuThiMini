using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class HangNhap
    {
        public string MaPN { get; set; }
        public string MaNCC { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TongTien { get; set; }
        public int TongSoLuong {  get; set; }
    }
}
