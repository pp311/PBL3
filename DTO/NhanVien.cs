using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DTO
{
    public class NhanVien
    {
        public int ID_NhanVien { get; set; }
        public int ID_TaiKhoan { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string ViTri { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TaiKhoan { get; set; }
    }
}
