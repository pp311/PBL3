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
    public class BLL_BaoHanh
    {
        PBLEntities db;
        private static BLL_BaoHanh _Instance;
        public static BLL_BaoHanh Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_BaoHanh();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_BaoHanh()
        {
            db = new PBLEntities();
        }
        public DataTable GetDanhSachBaoHanh()
        {
            var l = (from ttbh in db.thongtinbaohanhs.AsEnumerable()
                    select new
                    {
                        ID_BaoHanh = ttbh.ID_BaoHanh,
                        ID_HoaDon = ttbh.ID_HoaDon,
                        ID_LoHang = ttbh.ID_LoHang,
                        ID_SanPham = ttbh.ID_SanPham,
                        TenSanPham = BLL_SanPham.Instance.GetTenSanPham(ttbh.ID_SanPham),
                        HanBaoHanh = ttbh.HanBaoHanh,
                        Serial = ttbh.Serial
                    }).ToList();
            return Helper.ToDataTable(l);
        }
        public DataTable GetDanhSachBaoHanhByKeyWord(string kw)
        {
            kw = kw.ToLower();
            var l = (from ttbh in db.thongtinbaohanhs
                     where ttbh.ID_BaoHanh.ToString().Contains(kw) || ttbh.Serial.ToLower().Contains(kw) || ttbh.ID_HoaDon.ToString().Contains(kw)
                     select new
                     {
                         ID_BaoHanh = ttbh.ID_BaoHanh,
                         ID_HoaDon = ttbh.ID_HoaDon,
                         ID_LoHang = ttbh.ID_LoHang,
                         ID_SanPham = ttbh.ID_SanPham,
                         TenSanPham = BLL_SanPham.Instance.GetTenSanPham(ttbh.ID_SanPham),
                         HanBaoHanh = ttbh.HanBaoHanh,
                         Serial = ttbh.Serial
                     }).ToList();
            return Helper.ToDataTable(l);
        }
        public thongtinbaohanh GetThongTinBaoHanh (int idbh)
        {
            return db.thongtinbaohanhs.Where(p => p.ID_BaoHanh == idbh).First();
        }
        public void SaveLichSuBaoHanh(lichsubaohanh lsbh)
        {
            if(lsbh.STT == 0 )
            {
                db.lichsubaohanhs.Add(lsbh);
            }
            else
            {
                lichsubaohanh ls = db.lichsubaohanhs.Where(p => p.STT == lsbh.STT).FirstOrDefault();
                ls.ID_NhanVien = lsbh.ID_NhanVien;
                ls.TinhTrang = lsbh.TinhTrang;
                ls.GhiChuBaoHanh = lsbh.GhiChuBaoHanh;
                ls.NgayBaoHanh = lsbh.NgayBaoHanh;
            }
            db.SaveChanges();
        }
        public DataTable GetLichSuBaoHanh(int idbh)
        {
            var l = from lsbh in db.lichsubaohanhs
                    where lsbh.ID_BaoHanh == idbh
                    select new
                    {
                        STT = lsbh.STT,
                        ID_BaoHanh = idbh,
                        ID_NhanVien = lsbh.ID_NhanVien,
                        TinhTrang = lsbh.TinhTrang,
                        NgayBaoHanh = lsbh.NgayBaoHanh,
                    };
            return Helper.ToDataTable(l.ToList());
        }
        public lichsubaohanh GetLichSuBaoHanhBySTT(int stt)
        {
            return db.lichsubaohanhs.Where(p => p.STT == stt).First();
        }
        public bool CheckTinhTrangBaoHanh(int ID_BaoHanh)
        {
            if(db.lichsubaohanhs.Count(p => p.ID_BaoHanh == ID_BaoHanh) == 0)
            {
                return true;
            }
            return db.lichsubaohanhs.Where(p => p.ID_BaoHanh == ID_BaoHanh).All(p => 
            p.TinhTrang == "Đã hoàn thành" || p.TinhTrang == "Đã bàn giao cho khách");
        }
        public bool CheckHanBaoHanh(int ID_BaoHanh)
        {
            DateTime dt = Convert.ToDateTime(db.thongtinbaohanhs.Where(p => p.ID_BaoHanh == ID_BaoHanh).First().HanBaoHanh);
            if (dt.Date >= DateTime.Now.Date) return true;
            return false;
        }
        public DataTable GetSanPhamDangBaoHanh()
        {
            var l = from lsbh in db.lichsubaohanhs.AsEnumerable()
                    where lsbh.TinhTrang != "Đã hoàn thành" && lsbh.TinhTrang != "Đã bàn giao cho khách"
                    select new
                    {
                        STT = lsbh.STT,
                        ID_BaoHanh = lsbh.ID_BaoHanh,
                        TenSanPham = BLL_SanPham.Instance.GetTenSanPham(lsbh.thongtinbaohanh.ID_SanPham),
                        ID_NhanVien = lsbh.ID_NhanVien,
                        TinhTrang = lsbh.TinhTrang,
                        NgayBaoHanh = lsbh.NgayBaoHanh,
                    };
            return Helper.ToDataTable(l.ToList());

        }
        public void DeleteLichSuBaoHanh(int stt)
        {
            lichsubaohanh lsbh = db.lichsubaohanhs.Where(p => p.STT == stt).First();
            db.lichsubaohanhs.Remove(lsbh);
            db.SaveChanges();
        }
       
    }
}
