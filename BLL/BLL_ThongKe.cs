using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;
namespace Do_An.BLL
{
    public class BLL_ThongKe
    {
        private static BLL_ThongKe _instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_ThongKe();
                }
                return _instance;
            }
            private set { }
        }
        private BLL_ThongKe() { }

        public int SoSPDaNhap(DateTime date1, DateTime date2)
        {
            return DAL_ThongKe.Instance.SoSPDaNhap(date1, date2);
        }


        public int SoSPBanDuoc(DateTime date1 , DateTime date2)
        {
            return DAL_ThongKe.Instance.SoSPBanDuoc(date1, date2);
        }

        public long TongDoanhThu(DateTime date1, DateTime date2)
        {
            return DAL_ThongKe.Instance.TongDoanhThu(date1, date2);
        }
        public long TongLoiNhuan(DateTime date1, DateTime date2)
        {
            return DAL_ThongKe.Instance.TongLoiNhuan(date1, date2);
        }
        public long TongChi(DateTime date1, DateTime date2)
        {
            return DAL_ThongKe.Instance.TongChi(date1, date2);
        }


    }
}
