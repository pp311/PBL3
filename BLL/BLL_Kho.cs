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
    public class BLL_Kho
    {
        //GetDataTableKho
        PBLEntities db;
        private static BLL_Kho _Instance;
        public static BLL_Kho Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Kho();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_Kho()
        {
            db = new PBLEntities();
        }

        public DataTable GetDataTableKho() {

            var l = from lh in db.khoes
                    select new
                    {
                        ID_LoHang = lh.ID_LoHang,
                        ID_SanPham = lh.ID_SanPham,
                        TenSanPham = lh.sanpham.Ten,
                        NgayNhap = lh.NgayNhap,
                        SoLuongNhap = lh.SoLuongNhap,
                        SoLuong = lh.SoLuong,
                        GiaMua = lh.GiaMua,
                        GiaBan = lh.sanpham.GiaBan,
                        GiamGia = lh.GiamGia,
                        GiaKhuyenMai = lh.sanpham.GiaBan - lh.sanpham.GiaBan * lh.GiamGia / 100
                        };
                return Helper.ToDataTable(l.ToList());
            }
        public string ExcuteKho(kho data)
        {
            string msg = "";
            if (data.ID_LoHang != 0)
            {
                msg = UpdateKho(data);
            }
            else
            {
                msg = AddKho(data);
            }
            return msg;
        }
        public string AddKho(kho data)
        {
            data.SoLuong = data.SoLuongNhap;
            db.khoes.Add(data);
            db.SaveChanges();
            return "Thêm thông tin nhập hàng thành công";
        }

        public string UpdateKho(kho data)
        {
            //có lỗi thì sẽ overwrite tbao này
            string msg = "Cập nhật thông tin nhập hàng thành công";
            try
            {
                kho preData = db.khoes.Find(data.ID_LoHang);
                //trường hợp sửa sản phẩm nhập của lô hàng
                if (preData.ID_SanPham != data.ID_SanPham)
                {
                    if (preData.SoLuongNhap != preData.SoLuong)
                    {
                        return $"Không thể thay đổi sản phẩm của lô hàng vì đã có sản phẩm được bán đi.";
                    }
                    else
                    {
                        preData.ID_SanPham = data.ID_SanPham;
                    }
                }
                //trường hợp sản phẩm nhập của lô hàng không đổi
                //cần kiểm tra trường hợp bị hao hụt sau khi chỉnh sửa đơn nhập nhỏ hơn số lượng còn trong kho
                else
                {
                    if (preData.SoLuongNhap - data.SoLuongNhap > preData.SoLuong)
                    {
                        return $"Không thể cập nhật vì số lượng sản phẩm bị sửa bớt lớn hơn số lượng còn trong kho";
                    }
                    else
                    {
                        preData.SoLuong -= preData.SoLuongNhap - data.SoLuongNhap;
                    }
                }
                preData.ID_SanPham = data.ID_SanPham;
                preData.NgayNhap = data.NgayNhap;
                preData.SoLuongNhap = data.SoLuongNhap;
                preData.GiaMua = data.GiaMua;
                preData.GiamGia = data.GiamGia;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                msg = $"Có lỗi xảy ra!\n{ex.Message}";
            }
            return msg;
        }
        public string DeleteThongTinNhapHang(List<int> IDList)
        {
            string msg = "";
            int errCount = 0;
            foreach (var id in IDList)
            {
                kho lh = db.khoes.Find(id);
                if (lh.SoLuongNhap != lh.SoLuong)
                {
                    msg += $"Không thể xoá lô hàng có id: '{lh.ID_LoHang}' do có sản phẩm đã được bán đi.\n";
                    errCount++;

                }
                else
                {
                    try
                    {
                        db.khoes.Remove(lh);
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        msg += $"Có lỗi xảy ra khi xoá lô hàng '{id}': {e.Message}\n";
                        errCount++;
                    }
                }
            }
             return msg == "" ? msg + $"Xoá thành công {IDList.Count - errCount} lô hàng" : msg;

        }
    }
}





