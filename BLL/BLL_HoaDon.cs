using Do_An.DAL;
using Do_An.DTO;
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
    public class BLL_HoaDon
    {
        PBLEntities db;
        private static BLL_HoaDon _Instance;
        public static BLL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDon();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HoaDon() {
            db = new PBLEntities();
        }

        DAL_HoaDon dshd = new DAL_HoaDon();
        public List<HoaDon> GetAllHoaDon()
        {
            return dshd.GetAllHoaDon();
        }
        public void DelHoaDon(List<string> del)
        {
            foreach (string delItem in del)
            {
                DAL_HoaDon.Instance.DelHoaDon(delItem);
            }
        }
        public HoaDon GetHoaDonByID(int ID)
        {
            HoaDon hd = new HoaDon();
            foreach (HoaDon i in GetAllHoaDon())
            {
                if (i.ID_HoaDon == ID)
                {
                    hd = i;
                }
            }
            return hd;
        }

        public void UpdateHoaDon(HoaDon hd)
        {
            DAL_HoaDon.Instance.UpdateHoaDon(hd);
        }
        public DataTable GetDataTableChiTietHoaDonByIDHoaDon(int idhd)
        {
            var l = from cthd in db.chitiethoadons
                    where cthd.ID_HoaDon == idhd
                    select new
                    {
                        ID_LoHang = cthd.ID_LoHang,
                        ID_SanPham = cthd.kho.ID_SanPham,
                        TenSanPham = cthd.kho.sanpham.Ten,
                        SoLuongMua = cthd.SoLuongMua,
                        GiamGia = cthd.GiamGia,
                        DonGia = cthd.DonGia,
                    };
            return Helper.ToDataTable(l.ToList());
        }
        public hoadon GetThongTinHoaDonByIDHoaDon(int id)
        {
            var l = db.hoadons.Where(h => h.ID_HoaDon == id).First();
            return l;
        }
        public dynamic GetDataTableAddThongTinBaoHanh(int ID_HoaDon)
        {
            if (!db.thongtinbaohanhs.Any(p => p.ID_HoaDon == ID_HoaDon))
            {
                var l = (from cthd in db.chitiethoadons
                        where cthd.ID_HoaDon == ID_HoaDon && cthd.kho.sanpham.chitietsanpham.ThoiHanBaoHanh > 0
                        select new
                        {
                            ID_LoHang = cthd.ID_LoHang,
                            ID_SanPham = cthd.kho.ID_SanPham,
                            TenSanPham = cthd.kho.sanpham.Ten,
                            SoLuongMua = cthd.SoLuongMua,
                            GiamGia = cthd.GiamGia,
                            DonGia = cthd.DonGia,
                        }).ToList();
                List<dynamic> rs = new List<dynamic>();
                foreach (var row in l)
                {
                    for(int i = 1; i <= row.SoLuongMua; i++)
                    {
                        rs.Add(new
                        {
                            ID_BaoHanh = 0,
                            ID_LoHang = row.ID_LoHang,
                            ID_SanPham = row.ID_SanPham,
                            TenSanPham = row.TenSanPham,
                            Serial = ""
                        });
                    }
                }
                return rs;
            }
            else
            {
                var l = db.thongtinbaohanhs.Where(p => p.ID_HoaDon == ID_HoaDon)
                    .AsEnumerable().Select(ttbh => new
                    {
                        ID_BaoHanh = ttbh.ID_BaoHanh,
                        ID_LoHang = ttbh.ID_LoHang,
                        ID_SanPham = ttbh.ID_SanPham,
                        TenSanPham = BLL_SanPham.Instance.GetTenSanPham(ttbh.ID_SanPham),
                        Serial = ttbh.Serial,
                    } );
                      
                return l.ToList();
            }
        }
        public void SaveThongTinBaoHanh(List<thongtinbaohanh> data)
        {
            foreach(var i in data)
            {
                int thoiHanBaoHanh = BLL_SanPham.Instance.GetThoiHanBaoHanh(i.ID_SanPham);
                hoadon hd = GetThongTinHoaDonByIDHoaDon(i.ID_HoaDon);
                i.HanBaoHanh = hd.NgayTao.AddDays(30 * thoiHanBaoHanh);
                if(i.ID_BaoHanh == 0 )
                    db.thongtinbaohanhs.Add(i);
                else
                {
                    thongtinbaohanh ttbh = db.thongtinbaohanhs.Where(p => p.ID_BaoHanh == i.ID_BaoHanh).First();
                    ttbh.Serial = i.Serial;
                }
            db.SaveChanges();
            }
        }

    }
}
