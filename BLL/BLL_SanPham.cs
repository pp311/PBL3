using Do_An.DAL;
using Do_An.DTO;
using Do_An.EF;
using Do_An.Utils;
using System.Data;

namespace Do_An.BLL
{
    public class BLL_SanPham
    {
        PBLEntities db;
        private static BLL_SanPham _Instance;
        public static BLL_SanPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SanPham();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SanPham()
        {
            db = new PBLEntities();
        }

        public DataTable GetDataTableSanPham()
        {
            var l = from p in db.sanphams
                    select new 
                    {
                        ID_SanPham = p.ID_SanPham,
                        Ten = p.Ten,
                        PhanLoai = p.PhanLoai,
                        GiaBan = p.GiaBan,
                    };
            return Helper.ToDataTable(l.ToList());
        }
        public DataTable GetDataTableSanPhamByType(string type)
        {
            if (type != "Tất cả")
            {
                DataTable dt = Instance.GetDataTableSanPham();
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
                return Instance.GetDataTableSanPham();
            }
        }
        public DataTable GetDataTableSanPhamByKeyWord(string type, string keyWord)
        {
            DataTable dt = GetDataTableSanPhamByType(type);
            keyWord = keyWord.ToLower();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!(dt.Rows[i]["Ten"].ToString().ToLower().Contains(keyWord)) &&
                    !(dt.Rows[i]["ID_SanPham"].ToString().ToLower().Contains(keyWord)) &&
                    !(GetThongSoKyThuatByIDSanPham((int)dt.Rows[i]["ID_SanPham"]).ToString().ToLower().Contains(keyWord)))
                {
                    dt.Rows.Remove(dt.Rows[i]);
                    i--;
                }
            }
            return dt;
        }
        public ChiTietSanPhamView GetChiTietSanPhamViewByIDSanPham(int ID_SanPham)
        {
            var l = (from sp in db.sanphams
                     join
                        ctsp in db.chitietsanphams
                        on sp.ID_SanPham equals ctsp.ID_SanPham
                     where sp.ID_SanPham == ID_SanPham
                     select new ChiTietSanPhamView
                     {
                         ID_SanPham = sp.ID_SanPham,
                         Ten = sp.Ten,
                         PhanLoai = sp.PhanLoai,
                         GiaBan = sp.GiaBan,
                         XuatXu = ctsp.XuatXu,
                         NamSX = (int)ctsp.NamSX,
                         ThoiHanBaoHanh = (int)ctsp.ThoiHanBaoHanh,
                         ThongSoKyThuat = ctsp.ThongSoKyThuat,
                         TenHang = ctsp.TenHang
                     }).First();
            return l;
        }
        public void UpdateThongTinSanPham(ChiTietSanPhamView data)
        {
            sanpham sp = db.sanphams.Find(data.ID_SanPham);
            sp.ID_SanPham = data.ID_SanPham;
            sp.Ten = data.Ten;
            sp.PhanLoai = data.PhanLoai;
            sp.GiaBan = data.GiaBan;

            chitietsanpham ctsp = db.chitietsanphams.Where(p => p.ID_SanPham == data.ID_SanPham).First();
            ctsp.NamSX = data.NamSX;
            ctsp.TenHang = data.TenHang;
            ctsp.ThoiHanBaoHanh = data.ThoiHanBaoHanh;
            ctsp.XuatXu = data.XuatXu;
            ctsp.ThongSoKyThuat = data.ThongSoKyThuat;
            db.SaveChanges();
        }
        public void AddThongTinSanPham(ChiTietSanPhamView data)
        {
            sanpham sp = new sanpham();
            sp.Ten = data.Ten;
            sp.PhanLoai = data.PhanLoai;
            sp.GiaBan = data.GiaBan;
            db.sanphams.Add(sp);
            db.SaveChanges();
            int id = db.sanphams.OrderByDescending(x => x.ID_SanPham).Select(p => p.ID_SanPham).First();
            chitietsanpham ctsp = new chitietsanpham
            {
                ID_SanPham = id,
                XuatXu = data.XuatXu,
                NamSX = data.NamSX,
                ThoiHanBaoHanh = data.ThoiHanBaoHanh,
                ThongSoKyThuat = data.ThongSoKyThuat,
                TenHang = data.TenHang,
            };
            db.chitietsanphams.Add(ctsp);
            db.SaveChanges();

        }
        public string DeleteThongTinSanPham(List<int> IDList)
        {
            string msg = "";
            int errorCount = 0;
            foreach (var id in IDList)
            {
                sanpham sp = db.sanphams.Find(id);
                if (sp.khoes.Any(p => p.SoLuong != 0 ))
                {
                    errorCount++;
                    msg += $"Không thể xoá thông tin của sản phẩm có tên '{sp.Ten}' do sản phẩm đã từng được nhập vào kho trước đây.\n";
                }
                else
                {
                    try
                    {
                        chitietsanpham ctsp = db.chitietsanphams.Where(p => p.ID_SanPham == id).First();
                        db.chitietsanphams.Remove(ctsp);
                        db.sanphams.Remove(sp);
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        msg += $"Có lỗi xảy ra khi xóa '{sp.Ten}': {e.Message}\n";
                        errorCount++;
                    }
                }
            }
            if (msg == "") return $"Xoá thành công {IDList.Count - errorCount} sản phẩm";
            return msg;
        }
        public string ExcuteDB(ChiTietSanPhamView data)
        {
            string msg = "";
            if(data.ID_SanPham != 0)
            {
                if (db.sanphams.Any(p => p.Ten == data.Ten && p.ID_SanPham != data.ID_SanPham))
                {
                    return "Thông tin sản phẩm này đã tồn tại";
                }
                UpdateThongTinSanPham(data);
            }
            else
            {
                if (db.sanphams.Any(p => p.Ten == data.Ten))
                {
                    return "Thông tin sản phẩm này đã tồn tại";
                }
                AddThongTinSanPham(data);
            }
            return msg;
        }    
        public int GetThoiHanBaoHanh(int ID_SanPham)
        {
            return db.chitietsanphams.Where(p => p.ID_SanPham == ID_SanPham).First()?.ThoiHanBaoHanh ?? 0;
        }
        public string GetTenSanPham(int ID_SanPham)
        {
            return db.sanphams.Where(p => p.ID_SanPham == ID_SanPham).First()?.Ten ?? "";
        }
        public string GetThongSoKyThuatByIDSanPham(int ID_SanPham)
        {
            return db.chitietsanphams.FirstOrDefault(p => p.ID_SanPham == ID_SanPham)?.ThongSoKyThuat ?? "";
        }
    }
}
