using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DTO;
using Do_An.DAL;
using Do_An.EF;

namespace Do_An.BLL
{
   public class BLL_NhanVien
    {
        PBLEntities db;
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
        private BLL_NhanVien() {
            db = new PBLEntities();
        }


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
                tk.MatKhau = BLL_TaiKhoan.EncodePass(tk.MatKhau);
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

        public string GetTenNhanVien(int id)
        {
            return db.nhanviens.Where(p => p.ID_NhanVien == id).First()?.TenNhanVien ?? "";
        }



    }
}
