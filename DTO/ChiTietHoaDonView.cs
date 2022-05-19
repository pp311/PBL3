using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DTO
{
    public class ChiTietHoaDonView
    {
        public int ID_HoaDon { get; set; }
        public int ID_LoHang { get; set; }
        public int ID_NhanVien { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public DateTime NgayTao { get; set; }   
        public int SoLuongMua { get; set; }
        public int GiamGia { get; set; }
        public int DonGia { get; set; }
    }
}
