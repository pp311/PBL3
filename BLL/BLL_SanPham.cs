using Do_An.DAL;
using Do_An.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.BLL
{
    public class BLL_SanPham
    {
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
        }
        public List<SanPhamView> GetListSanPhamView ()
        {
            List<SanPhamView> list = new List<SanPhamView>();
            list = DAL_SanPham.Instance.GetAllSanPhamView();
            return list;
        }
        public DataTable GetDataTableSanPham()
        {
            return DAL_SanPham.Instance.GetAllSanPhamToDataTable();
        }
        public ChiTietSanPhamView GetChiTietSanPhamViewByIDSanPham(int ID_SanPham)
        {
            ChiTietSanPhamView data = DAL_SanPham.Instance.GetChiTietSanPhamView(ID_SanPham);
            return data;
        }
        public void UpdateThongTinSanPham(ChiTietSanPhamView data)
        {
            DAL_SanPham.Instance.UpdateThongTinSanPham(data);
        }
        public void AddThongTinSanPham(ChiTietSanPhamView data)
        {
            DAL_SanPham.Instance.AddThongTinSanPham(data);
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
     
    }
}
