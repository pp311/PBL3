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
    public class DAL_TaiKhoan
    {

        private static DAL_TaiKhoan _Instance;
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_TaiKhoan();
                }
                return _Instance;
            }
            private set { }
        }

        public DAL_TaiKhoan() { }
 
        public TaiKhoan GetTK(DataRow i)
        {
            return new TaiKhoan
            {
                ID_TaiKhoan = Convert.ToInt32(i["ID_TaiKhoan"].ToString()),
                TenTaiKhoan = i["TenTaiKhoan"].ToString(),
                MatKhau = i["MatKhau"].ToString(),


            };
        }
        public void DAL_AddTaiKhoan(TaiKhoan tk)
        {
           // string query = "insert into taikhoan values('{0}','{1}','{2}')"+tk.ID_TaiKhoan+tk.TenTaiKhoan+tk.MatKhau;
            string query = "insert into taikhoan values('{1}','{2}')" + tk.TenTaiKhoan + tk.MatKhau;
            DBHelper.Instance.GetRecord(query);
        }
        

        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> data = new List<TaiKhoan>();
            string query = "select * from taikhoan ";
            //select  * from nhanvien
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                data.Add(GetTK(i));
            }
            return data;
        }
        /* public void DAL_AddTaiKhoan(TaiKhoan tk)
         {
             //  string query_add_idtk = "insert into taikhoan values ('{0}','{1}')" + tk.TenTaiKhoan + tk.MatKhau;

             string query = $"insert into taikhoan " +
                  $"values ('{tk.TenTaiKhoan}', '{tk.MatKhau}')";
             // add nhanvien bang id tk 

             DBHelper.Instance.ExcuteDB(query);
         }*/
        public void DAL_UpdatePass(TaiKhoan tk)
        {
            string query = $"update taikhoan set MatKhau = N'{tk.MatKhau}' where ID_TaiKhoan ='{tk.ID_TaiKhoan}'";
            DBHelper.Instance.ExcuteDB(query);
        }
    }
}
