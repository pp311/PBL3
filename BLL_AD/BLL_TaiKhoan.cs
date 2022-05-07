using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Do_An.DTO_AD;
using Do_An.DAL_AD;
<<<<<<< HEAD

=======
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
namespace Do_An.BLL_AD
{
    public class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan _instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLL_TaiKhoan();
                }
                return _instance;
            }
            private set { }
        }
        public BLL_TaiKhoan() { }

        DAL_TaiKhoan dstk = new DAL_TaiKhoan();
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return dstk.GetAllTaiKhoan();
        }
        /*  public NhanVien BLL_GetNhanVienByID(int id)
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
          }*/
        public TaiKhoan BLL_GetTaiKhoanByID(int id)
        {
            TaiKhoan tk = new TaiKhoan();
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
                if (i.ID_TaiKhoan == id)
                {
                    tk = i;
                }
            }
            return tk;
        }
<<<<<<< HEAD
        public TaiKhoan BLL_GetTaiKhoanByIDNV(NhanVien nv)
=======
  /*      public TaiKhoan BLL_GetTaiKhoanByTenTaiKhoan(string s)
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        {
            TaiKhoan tk = new TaiKhoan();
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
<<<<<<< HEAD
                if (i.ID_TaiKhoan == nv.ID_TaiKhoan)
                    tk = i;
            }
                return tk;
        }
        /*      public TaiKhoan BLL_GetTaiKhoanByTenTaiKhoan(string s)
              {
                  TaiKhoan tk = new TaiKhoan();
                  foreach (TaiKhoan i in GetAllTaiKhoan())
                  {
                      if (i.TenTaiKhoan == s)
                      {
                          tk = i;
                      }
                  }
                  return tk;
              }*/
=======
                if (i.TenTaiKhoan == s)
                {
                    tk = i;
                }
            }
            return tk;
        }*/
>>>>>>> 39bd742a88e038cf788aeeb430f6043d93765d80
        public void AddTaiKhoan(TaiKhoan tk)
        {
            DAL_TaiKhoan.Instance.DAL_AddTaiKhoan(tk);

        }


        public void UpdatePass(TaiKhoan tk)
        {
            DAL_TaiKhoan.Instance.DAL_UpdatePass(tk);
        }


    }
}
