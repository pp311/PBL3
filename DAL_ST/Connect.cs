using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Do_An.DAL_ST
{
    public class Connect
    {
        public string conn;
        public Connect()
        {
            conn= @"Data Source=DESKTOP-6DUEMNF\SQLEXPRESS;Initial Catalog=PBL;Integrated Security=True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
    }
}
