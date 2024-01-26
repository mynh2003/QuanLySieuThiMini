using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class HangBan
    {
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime NgayTao { get; set; }
        public int TongTien { get; set; }
        public int TongSoLuong { get; set; }
    }
}
