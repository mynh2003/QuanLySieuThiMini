using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class BangLuong
    {
        DbConnection db = new DbConnection();
        public string MaNV {  get; set; }
        public string TenNV { get; set; }
        public int TongCa { get; set; }
        public string ThangNam { get; set; }
        public int TongLuong { get; set; }
    }
}
