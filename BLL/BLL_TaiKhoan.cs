using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Do_An.DTO;
using Do_An.DAL;

namespace Do_An.BLL
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

        public TaiKhoan BLL_GetTaiKhoanByIDNV(NhanVien nv)

        {
            TaiKhoan tk = new TaiKhoan();
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
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

        public void AddTaiKhoan(TaiKhoan tk)
        {
            DAL_TaiKhoan.Instance.DAL_AddTaiKhoan(tk);

        }


        public void UpdatePass(TaiKhoan tk)
        {
            DAL_TaiKhoan.Instance.DAL_UpdatePass(tk);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();

            ////Tạo MD5 
            //MD5 mh = MD5.Create();
            ////Chuyển kiểu chuổi thành kiểu byte
            //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes("Chuỗi cần mã hóa");
            ////mã hóa chuỗi đã chuyển
            //byte[] hash = mh.ComputeHash(inputBytes);
            ////tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < hash.Length; i++)
            //{
            //    sb.Append(hash[i].ToString("X2"));
            //}
            //return sb.ToString();
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
            //trong "X2" thành "x"
        }


        public static string EncodePass(string pass)
        {
            return MD5Hash(Base64Encode(pass));
        }

    }
}
