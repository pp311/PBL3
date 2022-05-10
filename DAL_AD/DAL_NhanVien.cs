using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Do_An.DTO_AD;
using System.Data.SqlClient;
namespace Do_An.DAL_AD
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien _Instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_NhanVien();
                }
                return _Instance;
            }
            private set { }
        }

        public DAL_NhanVien() { }
        
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> data = new List<NhanVien>();
            string query = "select * from nhanvien inner join taikhoan on nhanvien.ID_TaiKhoan = taikhoan.ID_TaiKhoan ";
            //select  * from nhanvien
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                data.Add(GetNV(i));
            }
            return data;
        }
        public NhanVien GetNV(DataRow i)
        {
            return new NhanVien
            {
                ID_NhanVien = Convert.ToInt32(i["ID_NhanVien"]),
                ID_TaiKhoan = Convert.ToInt32(i["ID_TaiKhoan"]),
                TenNhanVien = i["TenNhanVien"].ToString(),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"]),
                GioiTinh = i["GioiTinh"].ToString(),
                ViTri = i["ViTri"].ToString(),
                SoDienThoai = i["SoDienThoai"].ToString(),
                DiaChi = i["DiaChi"].ToString(),
                TaiKhoan = i["TenTaiKhoan"].ToString(),

            };
        }

        // 

        //

        public void DAL_GetNhanVienByID(int id)
        {
            string query = "select * from nhanvien where ID_NhanVien=" + id;
            DBHelper.Instance.ExcuteDB(query);
        }

        public void DAL_AddNhanVien(NhanVien nv, TaiKhoan tk)
        {


            string query = $"insert into taikhoan " + $"values ('{tk.TenTaiKhoan}', '{tk.MatKhau}')";
            // add nhanvien bang id tk 
            DBHelper.Instance.ExcuteDB(query);

            string query1 = "SELECT TOP 1 ID_TaiKhoan FROM taikhoan ORDER BY ID_TaiKhoan DESC";
            int idtk = -1;
            DataRow i = DBHelper.Instance.GetRecord(query1).Rows[0];

            idtk = Convert.ToInt32(i["ID_TaiKhoan"]);


            string query123 = string.Format("insert into nhanvien values ({0} ,N'{1}','{2}' ,N'{3}',N'{4}','{5}',N'{6}') ",
       idtk, nv.TenNhanVien, nv.NgaySinh.ToString("yyyy-MM-dd"), nv.GioiTinh, nv.ViTri, nv.SoDienThoai, nv.DiaChi);

            DBHelper.Instance.ExcuteDB(query123);

        }



        public void DAL_UpdateNhanVien(NhanVien nv)
        {
            string querynv = $"update nhanvien set TenNhanVien = N'{nv.TenNhanVien.ToString()}', NgaySinh = '{nv.NgaySinh.ToString("yyyy-MM-dd")}', GioiTinh = N'{nv.GioiTinh}'" +
                $",ViTri = N'{nv.ViTri}', DiaChi = N'{nv.DiaChi}',SoDienThoai='{nv.SoDienThoai}' where ID_NhanVien ='{nv.ID_NhanVien}'";



            /*     string query_update_nv = $"update nhanvien set  TenNhanVien =' " + nv.TenNhanVien + "' ,ID_TaiKhoan ='" + nv.ID_TaiKhoan + "',NgaySinh='" + nv.NgaySinh.ToString() +
                    "',GioiTinh='" + nv.GioiTinh + "',ViTri='" + nv.ViTri + "',SoDienThoai='" + nv.SoDienThoai + "',DiaChi='" + nv.DiaChi + " where ID_NhanVien ='" + nv.ID_NhanVien;
               */

            DBHelper.Instance.ExcuteDB(querynv);

        }

        public void DAL_DelNhanVien(string id_nv)
        // chọn id 

        {
            string query = "select ID_TaiKhoan from nhanvien where ID_NhanVien=" + id_nv;
            DataTable dt = DBHelper.Instance.GetRecord(query);
            int idtk = -1;
            foreach (DataRow i in dt.Rows)
            {
                idtk = Convert.ToInt32(i["ID_TaiKhoan"]);
            }
            // xóa tk nv 
            string query_delidnv = "delete from nhanvien where ID_NhanVien =" + id_nv;
            DBHelper.Instance.ExcuteDB(query_delidnv);
            string query_delidtk = "delete from taikhoan where ID_TaiKhoan =" + idtk;
            DBHelper.Instance.ExcuteDB(query_delidtk);



        }

    }
}
