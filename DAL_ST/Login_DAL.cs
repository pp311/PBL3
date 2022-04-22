using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Do_An.DAL_ST
{
    public class Login_DAL
    {
        Connect dc;
        SqlDataAdapter ad, ad_;
        private DataTable dt= new DataTable();
        private static Login_DAL _Instance;
        public string TenTaiKhoan = "";
        public string MatKhau = "";
        public string ID_TaiKhoan;
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
    }
}
