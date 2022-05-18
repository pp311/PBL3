using Do_An.DAL;
using Do_An.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.BLL
{
    public class BLL_HoaDon
    {
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
        private BLL_HoaDon() { }

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
        public HoaDon GetHoaDonByID (int ID)
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

        public void UpdateHoaDon (HoaDon hd)
        {
            DAL_HoaDon.Instance.UpdateHoaDon(hd);
        }

    }
}
