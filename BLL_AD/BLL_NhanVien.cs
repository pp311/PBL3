using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DTO_AD;
using Do_An.DAL_AD;
namespace Do_An.BLL_AD
{
   public class BLL_NhanVien
    {
        private static BLL_NhanVien _instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_NhanVien();
                }
                return _instance;
            }
            private set { }
        }
        private BLL_NhanVien() { }


        DAL_NhanVien dsnv = new DAL_NhanVien();
        public List<NhanVien> GetAllNhanVien()
        {
            return dsnv.GetAllNhanVien();
        }

        public void DelNhanVien(List<string> del)
        {
            foreach (string i in del)
            {
                DAL_NhanVien.Instance.DAL_DelNhanVien(i);
            }
        }
        public void AddNhanVien(NhanVien nv, TaiKhoan tk)
        {
            DAL_NhanVien.Instance.DAL_AddNhanVien(nv, tk);

        }


        public NhanVien BLL_GetNhanVienByID(int id)
        {
            NhanVien nv = new NhanVien();
            foreach (NhanVien i in GetAllNhanVien())
            {
                if (i.ID_NhanVien == id)
                {
                    nv = i;
                }
            }
            return nv;
        }

/*        public bool check(int ID_NhanVien)
        {
            foreach(NhanVien i in GetAllNhanVien())
            {
                if(ID_NhanVien==i.ID_NhanVien)
                {
                    return true;
                }
             
            }
            return false;
        }*/

        public void Update(NhanVien nv)
        {
            DAL_NhanVien.Instance.DAL_UpdateNhanVien(nv);
        }



    }
}
