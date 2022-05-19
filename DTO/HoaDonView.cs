using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DTO
{
    public class HoaDonView
    {
        public int ID_HoaDon { get; set; }
        public int ID_NhanVien { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public int TongTien { get; set; }
        public int ID_LoHang { get; set; }
    }
}
