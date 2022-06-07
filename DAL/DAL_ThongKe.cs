using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.BLL;
using System.Data;
using Do_An.DTO;
using System.Data.SqlClient;
namespace Do_An.DAL
{
    public  class DAL_ThongKe
    {
        private static DAL_ThongKe _Instance;
        public static DAL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }

        public DAL_ThongKe() { }

        public int SoSPDaNhap(DateTime date1, DateTime date2)
        {
            
            string query = string.Format("select sum(soluongnhap) from kho where NgayNhap >= '{0}' and NgayNhap <= '{1}' " , date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));
            DataTable dt = DBHelper.Instance.GetRecords(query);
            int sum = 0;
            foreach (DataRow i in dt.Rows)
            {
                if (i[0].ToString() != "")
                {
                    sum = Convert.ToInt32(i[0]);
                }
            }
            return sum;
        }
            public int SoSPBanDuoc(DateTime date1 , DateTime date2)
        {         
            string query = string.Format("select sum(soluongmua) from chitiethoadon,hoadon where NgayTao >= '{0}' and NgayTao <= '{1}' " +
                "and chitiethoadon.ID_HoaDon = hoadon.ID_HoaDon", date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));
            DataTable dt = DBHelper.Instance.GetRecords(query);
            int sum = 0;
            foreach (DataRow i in dt.Rows)
            {
                if(i[0].ToString()!="")
                {
                 sum = Convert.ToInt32(i[0]);
                }                   
            }
            return sum;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public long TongChi(DateTime date1, DateTime date2)
        {
            string query1 = string.Format("select sum(cast(soluongmua*giamua as bigint)) from kho,chitiethoadon where NgayNhap >= '{0}' and NgayNhap <= '{1}'and chitiethoadon.ID_LoHang = kho.ID_LoHang"
                , date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));
            string query = string.Format("select sum(convert(bigint,giamua)*soluongnhap) from kho where NgayNhap >= '{0}' and NgayNhap <= '{1}'"
                , date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));
            DataTable dt = DBHelper.Instance.GetRecords(query);
            long sum = 0;
            foreach (DataRow i in dt.Rows)
            {
                if (i[0].ToString() != "")
                {
                    sum = Convert.ToInt64(i[0]);
                }
            }
            return sum;
        }
        public long TongLoiNhuan(DateTime date1, DateTime date2)
        {
            long sum2 = TongDoanhThu(date1, date2);
            long sum1 = TongChi(date1, date2);
            return sum2 - sum1;
        }
        public long TongDoanhThu(DateTime date1, DateTime date2)
        {
            // tổng tiền hóa đơn
            /*string query = string.Format("select sum(giaban) from kho,sanpham where NgayNhap >= '{0}' and NgayNhap <= '{1}' and kho.ID_SanPham = sanpham.ID_SanPham"
              , date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));*/
            string query = string.Format("select sum(tongtien) from hoadon where NgayTao >= '{0}' and NgayTao <= '{1}'"
              , date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd"));
            DataTable dt = DBHelper.Instance.GetRecords(query);
            long sum = 0;
            foreach (DataRow i in dt.Rows)
            {
                if (i[0].ToString() != "")
                {
                    sum = Convert.ToInt64(i[0]);
                }
            }
            return sum;
        }

    }
}
