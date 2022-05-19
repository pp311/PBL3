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
<<<<<<< HEAD

                    string s = @"Data Source=LAPTOP-H8F30CQH\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True";

=======
                    string s = @"Data Source=DESKTOP-V8TS0L2\SQLEXPRESS;Initial Catalog=PBL;Integrated Security=True";
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
<<<<<<< HEAD

            private set {  }

=======
            private set { _Instance = value; }
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
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
<<<<<<< HEAD

            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
=======
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

<<<<<<< HEAD

=======
>>>>>>> 33903dd8391e673206b1354cd8dda36707fc3556
            return dt;
        }
    }
}
