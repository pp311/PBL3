using Do_An.DTO;
using System.Data;

namespace Do_An.DAL
{
    public class DAL_SanPham
    {
        private static DAL_SanPham _Instance;
        public static DAL_SanPham Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SanPham();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_SanPham()
        {
        }
        public SanPhamView GetSanPhamViewByDataRow(DataRow i)
        {
            return new SanPhamView
            {
                ID_SanPham = Convert.ToInt32(i["ID_SanPham"]),
                Ten = i["Ten"].ToString(),
                PhanLoai = i["PhanLoai"].ToString(),
                GiaBan = Convert.ToInt32(i["GiaBan"]),
                GiamGia = Convert.ToInt32(i["GiamGia"]),
                SoLuong = Convert.ToInt32(i["SoLuong"]),
            };
        }
        public List<SanPhamView> GetAllSanPhamView()
        {
            List<SanPhamView> list = new List<SanPhamView>();
            string query = "select sanpham.ID_SanPham, Ten, PhanLoai, GiaBan, GiamGia, SoLuong" +
                " from dbo.sanpham inner join chitietsanpham on sanpham.ID_SanPham = chitietsanpham.ID_SanPham" +
                " inner join kho on sanpham.ID_SanPham = kho.ID_SanPham";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(GetSanPhamViewByDataRow(i));
            }

            return list;
        }
        public DataTable GetAllSanPhamToDataTable()
        {
            string query = "select sanpham.ID_SanPham, Ten, PhanLoai, GiaBan, GiamGia, SoLuong" +
                " from dbo.sanpham inner join chitietsanpham on sanpham.ID_SanPham = chitietsanpham.ID_SanPham" +
                " inner join kho on sanpham.ID_SanPham = kho.ID_SanPham";
            return DBHelper.Instance.GetRecords(query);
        }

        public ChiTietSanPhamView GetChiTietSanPhamView(int id)
        {
            string query = $"select sanpham.ID_SanPham, Ten, TenHang, PhanLoai, GiaBan, GiamGia, XuatXu, NamSX, ThoiHanBaoHanh, ThongSoKyThuat" +
                " from dbo.sanpham inner join chitietsanpham on sanpham.ID_SanPham = chitietsanpham.ID_SanPham" +
                $" where sanpham.ID_SanPham = {id};";
            DataRow i = DBHelper.Instance.GetRecords(query).Rows[0];
            return new ChiTietSanPhamView
            {
                ID_SanPham = Convert.ToInt32(i["ID_SanPham"]),
                Ten = i["Ten"].ToString(),
                PhanLoai = i["PhanLoai"].ToString(),
                GiaBan = Convert.ToInt32(i["GiaBan"]),
                XuatXu = i["XuatXu"].ToString(),
                NamSX = Convert.ToInt32(i["NamSX"]),
                ThoiHanBaoHanh = Convert.ToInt32(i["ThoiHanBaoHanh"]),
                ThongSoKyThuat = i["ThongSoKyThuat"].ToString(),
                TenHang = i["TenHang"].ToString()
            };
        }
        public void UpdateThongTinSanPham(ChiTietSanPhamView data)
        {
            string query1 = $"update sanpham set Ten = N'{data.Ten}', PhanLoai = N'{data.PhanLoai}', " +
                $" GiaBan = {data.GiaBan} where ID_SanPham = {data.ID_SanPham}";
            DBHelper.Instance.ExcuteDB(query1);
            string query2 = $"update chitietsanpham set NamSX = {data.NamSX}, XuatXu = N'{data.XuatXu}', " +
                $" TenHang = N'{data.TenHang}', ThongSoKyThuat = N'{data.ThongSoKyThuat}', ThoiHanBaoHanh = {data.ThoiHanBaoHanh} " +
                $" where ID_SanPham = {data.ID_SanPham}";
            DBHelper.Instance.ExcuteDB(query2);
        }
        public void AddThongTinSanPham(ChiTietSanPhamView data)
        {
            string query1 = string.Format("insert into sanpham values (N'{0}', N'{1}', {2})"
                , data.Ten, data.PhanLoai, data.GiaBan);
            DBHelper.Instance.ExcuteDB(query1);
            string query = "SELECT TOP 1 ID_SanPham FROM sanpham ORDER BY ID_SanPham DESC";

            int id = -1;
            DataRow i = DBHelper.Instance.GetRecords(query).Rows[0];        
            id = Convert.ToInt32(i[0]);           
            string query2 = string.Format("insert into chitietsanpham values ({0}, {1}, N'{2}',N'{3}', N'{4}', {5})",
                id, data.NamSX, data.XuatXu, data.TenHang, data.ThongSoKyThuat, data.ThoiHanBaoHanh);
            DBHelper.Instance.ExcuteDB(query2);
            string query3 = $"insert into kho values ({id}, 0)";
            DBHelper.Instance.ExcuteDB(query3);
        }
    }
}
