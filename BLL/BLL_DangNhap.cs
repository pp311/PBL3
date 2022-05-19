using Do_An.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Do_An.DTO;
<<<<<<< HEAD
using System.Security.Cryptography;

=======
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556

namespace Do_An.BLL
{
    public class BLL_DangNhap
    {
        PBLEntities db;
        private static BLL_DangNhap _Instance;
        public static BLL_DangNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DangNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_DangNhap()
        {
            db = new PBLEntities();
        }
        //true => không có lỗi
        public bool DangNhap(string tk, string mk)
        {
<<<<<<< HEAD

  
            bool isError = false;
            try
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(mk);
                byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
                string hasPass = "";
                foreach (byte item in hasData)
                {
                    hasPass += item;
                }

=======
            bool isError = false;
            try
            {
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
                int idtk = db.taikhoans.Where(p => p.TenTaiKhoan == tk && p.MatKhau == mk).First().ID_TaiKhoan;
                nhanvien nhanVien = db.nhanviens.Where(p => p.ID_TaiKhoan == idtk).First();
                CurrentUser.ID_NhanVien = nhanVien.ID_NhanVien;
                CurrentUser.Name = nhanVien.TenNhanVien;
                CurrentUser.ViTri = nhanVien.ViTri;

            }
            catch (Exception ex)
            {
                isError = true;
            }
            return !isError;
        }
    }
}
