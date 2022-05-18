using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An.DAL
{
    public class DBHelper
    {
        private SqlConnection cnn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if(_Instance == null)
                {

                    string s = @"Data Source=DESKTOP-V8TS0L2\SQLEXPRESS;Initial Catalog=PBL;Integrated Security=True";

                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }

            private set {  }

        }

        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();


            return dt;
        }
    }
}
