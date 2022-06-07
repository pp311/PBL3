using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DTO
{
    public class SanPhamView
    {
        public int ID_SanPham { get; set; }
        public string Ten { get; set; }
        public string PhanLoai { get; set; }
        public int GiamGia { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }

    }
}
