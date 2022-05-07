using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Do_An.DTO_AD;
using Do_An.DAL_AD;
namespace Do_An.DAL_ST
{
    public class Login_DAL
    {
        Connect dc;
        SqlDataAdapter ad, ad_;
        private DataTable dt = new DataTable();
        private static Login_DAL _Instance;
        public string TenTaiKhoan = "";
        public string MatKhau = "";
        public string ID_TaiKhoan;
        public string ID_Nhanvien;
        SqlCommand cmd;
        public static Login_DAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new Login_DAL();
                return _Instance;
            }
            private set
            {

            }
        }
        public Login_DAL()
        {
            dc = new Connect();
        }
        /*  public bool ChangePass(string pass)
            {
                string query = " update taikhoan SET Password = @Pass WHERE Ten = '"+TenTaiKhoan+"'";"
            }
    */
        public DataTable GetThongTinCaNhan()
        {
            //   ID_TaiKhoan = "";

         /*   foreach (DataRow i in dt.Rows)
            {
                
                //
                ID_TaiKhoan = Convert.ToString(i["ID_TaiKhoan"]);
                string? ID_NhanVien = Convert.ToString(i["ID_NhanVien"]);
            }*/
           // inner join taikhoan on nhanvien.ID_TaiKhoan = taikhoan.ID_TaiKhoan where taikhoan.TenTaiKhoan = '" + tk + "'";
            string query = "select * from nhanvien  inner join taikhoan on nhanvien.ID_TaiKhoan = taikhoan.ID_TaiKhoan  where nhanvien.ID_TaiKhoan = " + ID_TaiKhoan;
            DataTable dt = DBHelper.Instance.GetRecord(query);
            int idtk = -1;
            foreach (DataRow i in dt.Rows)
            {
                idtk = Convert.ToInt32(i["ID_TaiKhoan"]);
            }

            SqlConnection Con = dc.getConnect();
            ad_ = new SqlDataAdapter(query, Con);
            Con.Open();
            DataTable TB_Staff = new DataTable();
            ad_.Fill(TB_Staff);
            if (TB_Staff.Rows.Count == 0) MessageBox.Show("Invalid Login please check" + ID_TaiKhoan+ " username and password");
            Con.Close();
            return TB_Staff;
        }
    
      
        }
}
