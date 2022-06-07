using Do_An.EF;
using Do_An.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.BLL
{
    public class BLL_BanHang
    {
        PBLEntities db;
        private static BLL_BanHang _Instance;
        public static BLL_BanHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_BanHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_BanHang()
        {
            db = new PBLEntities();
        }
        public DataTable GetDataTableBanHang()
        {

            var l = from lh in db.khoes
                    where lh.SoLuong > 0
                    select new
                    {
                        ID_LoHang = lh.ID_LoHang,
                        ID_SanPham = lh.ID_SanPham,
                        TenSanPham = lh.sanpham.Ten,
                        PhanLoai = lh.sanpham.PhanLoai,
                        NgayNhap = lh.NgayNhap,
                        SoLuongNhap = lh.SoLuongNhap,
                        SoLuong = lh.SoLuong,
                        GiamGia = lh.GiamGia,
                        GiaBanGoc = lh.sanpham.GiaBan,
                        GiaKhuyenMai = lh.sanpham.GiaBan - lh.sanpham.GiaBan*lh.GiamGia/100
                    };
            return Helper.ToDataTable(l.ToList());
        }
        public DataTable GetDataTableBanHangByType(string type)
        {
            if (type != "Tất cả")
            {
                DataTable dt = Instance.GetDataTableBanHang();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (!(dt.Rows[i]["PhanLoai"].ToString() == type))
                    {
                        dt.Rows.Remove(dt.Rows[i]);
                        i--;
                    }
                }
                return dt;

            }
            else
            {
                return Instance.GetDataTableBanHang();
            }
        }
        public DataTable GetDataTableBanHangByKeyWord(string type, string keyWord)
        {
            DataTable dt = GetDataTableBanHangByType(type);
            keyWord = keyWord.ToLower();
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    if (!(dt.Rows[i]["TenSanPham"].ToString().ToLower().Contains(keyWord) ||
                          dt.Rows[i]["ID_LoHang"].ToString().ToLower().Contains(keyWord) ||
                          dt.Rows[i]["ID_SanPham"].ToString().ToLower().Contains(keyWord)))
                    {
                        dt.Rows.Remove(dt.Rows[i]);
                        i--;
                    }
                }
            return dt;
        }
        public string AddHoaDon(DataTable danhSachMuaHang, hoadon thongTinHoaDon)
        {
            string msg = "";
            db.hoadons.Add(thongTinHoaDon);
            db.SaveChanges();
            int id = db.hoadons.OrderByDescending(x => x.ID_HoaDon).Select(p => p.ID_HoaDon).First();
            foreach(DataRow dr in danhSachMuaHang.Rows)
            {
                chitiethoadon cthd = new chitiethoadon
                {
                    ID_HoaDon = id,
                    ID_LoHang = Convert.ToInt32(dr["ID_LoHang"].ToString()),
                    SoLuongMua = Convert.ToInt32(dr["SoLuongMua"].ToString()),
                    GiamGia = Convert.ToInt32(dr["GiamGia"].ToString()),
                    DonGia = Convert.ToInt32(dr["DonGia"].ToString())
                };
                db.chitiethoadons.Add(cthd);
                kho sp = db.khoes.Where(p => p.ID_LoHang == cthd.ID_LoHang).First();
                sp.SoLuong -= cthd.SoLuongMua;
                db.SaveChanges();
            }
            return msg;
        }
        

    }
}
