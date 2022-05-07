using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DTO
{
    public class ChiTietSanPhamView
    {
        public int ID_SanPham { get; set; }
        public string Ten { get; set; }
        public int NamSX { get; set; }
        public string XuatXu { get; set; }
        public string TenHang { get; set; }
        public int ThoiHanBaoHanh { get; set; }
        public string ThongSoKyThuat { get; set; }
        public string PhanLoai { get; set; }
        public int GiaBan { get; set; }
    }
}
