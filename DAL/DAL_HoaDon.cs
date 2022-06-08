using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Do_An.DTO;
namespace Do_An.DAL
{
    public class DAL_HoaDon
    {
        private static DAL_HoaDon _Instance;
        public static DAL_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HoaDon();
                }
                return _Instance;
            }
            private set { }
        }
        public DAL_HoaDon() { }
        public HoaDon GetHoaDonByDataRow(DataRow i)
        {
            return new HoaDon
            {
                ID_HoaDon = Convert.ToInt32(i["ID_HoaDon"]),
                ID_NhanVien = Convert.ToInt32(i["ID_NhanVien"]),
                NgayTao = Convert.ToDateTime(i["NgayTao"]),
                TenKhachHang = i["TenKhachHang"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                TongTien = Convert.ToInt32(i["TongTien"]),
            };
        }
        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> data = new List<HoaDon>();
            string query = "select * from hoadon";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetHDByDataRow(i));
            }
            return data;
        }
        public HoaDon GetHDByDataRow(DataRow i)
        {
            return new HoaDon
            {
                ID_HoaDon = Convert.ToInt32(i["ID_HoaDon"]),
                ID_NhanVien = Convert.ToInt32(i["ID_NhanVien"]),
                NgayTao = Convert.ToDateTime(i["NgayTao"]),
                TenKhachHang = i["TenKhachHang"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                TongTien = Convert.ToInt32(i["TongTien"]),
            };
        }
        public DataTable GetAllHoaDonToDataTable()
        {
            string query = "select * from hoadon inner join chitiethoadon on hoadon.ID_HoaDon = chitiethoadon.ID_HoaDon";
            return DBHelper.Instance.GetRecords(query);
        }
        public void DAL_GetHoaDonByID(int id)
        {
            string query = "select * from hoadon where ID_HoaDon=" + id;
            DBHelper.Instance.ExcuteDB(query);
        }
        public ChiTietHoaDonView GetChiTietHoaDonView(int id)
        {
            string query = $"select hoadon.ID_HoaDon, ID_LoHang, ID_NhanVien, NgayTao, TenKhachHang, SoDienThoai, TongTien, SoLuongMua, GiamGia, DonGia" +
                " from dbo.hoadon inner join chitiethoadon on hoadon.ID_HoaDon = chitiethoadon.ID_HoaDon" +
                $" where hoadon.ID_HoaDon = {id};";
            DataRow i = DBHelper.Instance.GetRecords(query).Rows[0];
            return new ChiTietHoaDonView
            {
                ID_HoaDon = Convert.ToInt32(i["ID_HoaDon"]),
                ID_LoHang = Convert.ToInt32(i["ID_LoHang"]),
                ID_NhanVien = Convert.ToInt32(i["ID_NhanVien"]),
                SoLuongMua = Convert.ToInt32(i["SoLuongMua"]),
                GiamGia = Convert.ToInt32(i["GiamGia"]),
                DonGia = Convert.ToInt32(i["DonGia"])
            };
        }
       
        public void UpdateHoaDon(HoaDon hd)
        {
            string queryhd = $"update hoadon set ID_NhanVien = '{hd.ID_NhanVien}',NgayTao = '{hd.NgayTao.ToString("yyyy-MM-dd")}', TenKhachHang = N'{hd.TenKhachHang}',SoDienThoai='{hd.SoDienThoai}' where ID_HoaDon ='{hd.ID_HoaDon}'";
            DBHelper.Instance.ExcuteDB(queryhd);
        }

        public void DelHoaDon(string id_hd)
        {
            string q1 = "select ID_LoHang from chitiethoadon where chitiethoadon.ID_HoaDon=" + id_hd;
            DataTable dt = DBHelper.Instance.GetRecords(q1);
            int id_lh = -1;
            foreach (DataRow i in dt.Rows)
            {
                id_lh = Convert.ToInt32(i["ID_LoHang"]);
            }
            //them san pham vao lai kho
            string q2 = "update kho set SoLuong = SoLuong + (select SoLuongMua from chitiethoadon where ID_LoHang =" + id_lh + "and ID_HoaDon =" + id_hd + " ) where ID_LoHang =" + id_lh;
            DBHelper.Instance.ExcuteDB(q2);
            //xoa chi tiet hoa don
            string query = "delete from chitiethoadon where ID_HoaDon =" + id_hd;
            DBHelper.Instance.ExcuteDB(query);
            //xoa hoa don
            string query_delidhd = "delete from hoadon where ID_HoaDon =" + id_hd;
            DBHelper.Instance.ExcuteDB(query_delidhd);
        }
    }
}
