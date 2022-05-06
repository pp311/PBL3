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
        public List<SanPhamView> GetListSanPhamView()
        {
            var l = from p in db.sanphams
                    select new SanPhamView
                    {
                        ID_SanPham = p.ID_SanPham,
                        Ten = p.Ten,
                        PhanLoai = p.PhanLoai,
                        GiamGia = (int)p.GiamGia,
                        GiaBan = p.GiaBan,
                        SoLuong = (int)p.kho.SoLuong
                    };
            return l.ToList();

        }
        public DataTable GetDataTableSanPham()
        {
            var l  = from p in db.sanphams join
                            k in db.khoes
                            on p.ID_SanPham equals k.ID_SanPham
                                   select new SanPhamView
                                   {
                                       ID_SanPham = p.ID_SanPham,
                                       Ten = p.Ten,
                                       PhanLoai = p.PhanLoai,
                                       GiamGia = (int)p.GiamGia,
                                       GiaBan = p.GiaBan,
                                       SoLuong = (int)k.SoLuong
                                   };
            return Helper.ToDataTable(l.ToList());
        }
        public DataTable GetDataTableSanPhamByType(string type)
        {
            if (type != "Tất cả")
            {
                DataTable dt = BLL_SanPham.Instance.GetDataTableSanPham();
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
                return BLL_SanPham.Instance.GetDataTableSanPham();
            }
        }
        public DataTable GetDataTableSanPhamByKeyWord(string type, string keyWord)
        {
            DataTable dt = GetDataTableSanPhamByType(type);
            keyWord = keyWord.ToLower();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!(dt.Rows[i]["Ten"].ToString().ToLower().Contains(keyWord)))
                {
                    dt.Rows.Remove(dt.Rows[i]);
                    i--;
                }
            }
            return dt;
        }
        public ChiTietSanPhamView GetChiTietSanPhamViewByIDSanPham(int ID_SanPham)
        {
            ChiTietSanPhamView data = DAL_SanPham.Instance.GetChiTietSanPhamView(ID_SanPham);
            var l = (from sp in db.sanphams join
                    ctsp in db.chitietsanphams
                    on sp.ID_SanPham equals ctsp.ID_SanPham
                    where sp.ID_SanPham == ID_SanPham 
                    select new ChiTietSanPhamView
                    {
                        ID_SanPham = sp.ID_SanPham,
                        Ten = sp.Ten,
                        PhanLoai = sp.PhanLoai,
                        GiaBan = sp.GiaBan,
                        GiamGia = (int)sp.GiamGia,
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
            DAL_SanPham.Instance.UpdateThongTinSanPham(data);
        }
        public void AddThongTinSanPham(ChiTietSanPhamView data)
        {
            DAL_SanPham.Instance.AddThongTinSanPham(data);
        }
        public string DeleteThongTinSanPham(List<int> IDList)
        {
            string msg = "";
            foreach(var id in IDList)
            {
                sanpham sp = db.sanphams.Find(id);
                if (sp.kho.SoLuong != 0)
                {
                    msg += $"Không thể xoá sản phẩm có tên '{sp.Ten}' do số lượng còn trong kho khác 0 (còn {sp.kho.SoLuong})\n";
                }
                else
                {
                    try
                    {
                        kho k = db.khoes.Where(p => p.ID_SanPham == id).First();
                        db.khoes.Remove(k);
                        chitietsanpham ctsp = db.chitietsanphams.Where(p => p.ID_SanPham == id).First();
                        db.chitietsanphams.Remove(ctsp);
                        db.sanphams.Remove(sp);
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        msg += $"Có lỗi xảy ra\n{e.Message}\n";
                    }
                }
            }
            if (msg == "") return $"Xoá thành công {IDList.Count} sản phẩm";
            return msg;
        }
        public void ExcuteDB(ChiTietSanPhamView data)
        {
            if(data.ID_SanPham != 0)
            {
                UpdateThongTinSanPham(data);
            }
            else
            {
                AddThongTinSanPham(data);
            }
        }
        public DataTable GetDataTableNhapSanPham()
        {
            var l = from lh in db.nhaphangs
                            select new 
                            {
                                ID_LoHang = lh.ID_LoHang,
                                ID_SanPham = lh.ID_SanPham,
                                GiaMua = lh.GiaMua,
                                NgayNhap = lh.NgayNhap,
                                SoLuongNhap = lh.SoLuongNhap
                            };
            return Helper.ToDataTable(l.ToList());
        }
        public string ExcuteNhapHang(nhaphang data)
        {
            string msg = "";
            if(data.ID_LoHang != 0)
            {
                msg = UpdateThongTinNhapHang(data);
            }
            else
            {
                msg = AddThongTinNhapHang(data);
            }
            return msg;
        }
        public string UpdateThongTinNhapHang(nhaphang data)
        {
            //có lỗi thì sẽ overwrite tbao này
            string msg = "Cập nhật thông tin nhập hàng thành công";
            try
            {


                nhaphang preData = db.nhaphangs.Where(p => p.ID_LoHang == data.ID_LoHang).FirstOrDefault();
                //trường hợp sửa sản phẩm nhập của lô hàng
                //1. trừ bớt sl của sp cũ => có thể lỗi nếu sl còn trong kho < sl nhập của sp cũ
                //2. cộng thêm sl vào sp mới
                //3. thay đổi thông tin của lô hàng
                if (preData.ID_SanPham != data.ID_SanPham)
                {
                    if (preData.SoLuongNhap > preData.kho.SoLuong)
                    {
                        return $"Không thể cập nhật vì số lượng còn trong kho của sản phẩm ID:{preData.ID_SanPham} nhỏ hơn số lượng đã nhập trước đó của lô hàng";
                    }
                    else
                    {
                        kho oldSP = db.khoes.Where(p => p.ID_SanPham == preData.ID_SanPham).First();
                        kho newSP = db.khoes.Where(p => p.ID_SanPham == data.ID_SanPham).First();
                        oldSP.SoLuong -= preData.SoLuongNhap;
                        newSP.SoLuong += data.SoLuongNhap;
                    }
                }
                //trường hợp sản phẩm nhập của lô hàng không đổi
                //cần kiểm tra trường hợp bị hao hụt sau khi chỉnh sửa đơn nhập nhỏ hơn số lượng còn trong kho
                else
                {
                    if (preData.SoLuongNhap - data.SoLuongNhap > preData.kho.SoLuong)
                    {
                        return $"Không thể cập nhật vì số lượng sản phẩm bị sửa bớt lớn hơn số lượng còn trong kho";
                    }
                    else
                    {
                        kho sp = db.khoes.Where(p => p.ID_SanPham == preData.ID_SanPham).First();
                        sp.SoLuong -= preData.SoLuongNhap - data.SoLuongNhap;
                    }
                }
                preData.ID_SanPham = data.ID_SanPham;
                preData.NgayNhap = data.NgayNhap;
                preData.SoLuongNhap = data.SoLuongNhap;
                preData.GiaMua = data.GiaMua;
                db.SaveChanges();
            } catch (Exception ex)
            {
                msg = $"Có lỗi xảy ra!\n{ex.Message}";
            }
            return msg;
        }
        public string AddThongTinNhapHang(nhaphang data)
        {
            //có lỗi thì sẽ overwrite tbao này
            string msg = "Thêm thông tin nhập hàng thành công";
            try
            {
                kho sp = db.khoes.Where(p => p.ID_SanPham == data.ID_SanPham).FirstOrDefault();
                db.nhaphangs.Add(data);
                sp.SoLuong += data.SoLuongNhap;
                db.SaveChanges();
            } catch (Exception ex)
            {
                msg = $"Có lỗi xảy ra!\n{ex.Message}";
            }
            return msg;
        }
        public string DeleteThongTinNhapHang(List<int> IDList)
        {
            string msg = "";
            foreach (var id in IDList)
            {
                nhaphang lh = db.nhaphangs.Where(p => p.ID_LoHang == id).First();
                if (lh.SoLuongNhap > lh.kho.SoLuong)
                {
                    msg += $"Không thể xoá lô hàng có id: '{lh.ID_LoHang}' do số lượng còn trong kho nhỏ hơn số lượng bị trừ bớt khi xóa lô hàng\n";
                }
                else
                {
                    try
                    {
                        lh.kho.SoLuong -= lh.SoLuongNhap;
                        db.nhaphangs.Remove(lh);
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        msg += $"Có lỗi xảy ra\n{e.Message}\n";
                    }
                }
            }
            if (msg == "") return $"Xoá thành công {IDList.Count} lô hàng";
            return msg;

        }

    }
}
