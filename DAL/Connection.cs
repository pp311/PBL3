using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Do_An.DAL
{
    public class Connection
    {
        string constr;
        public Connection()
        {
            constr = @"Data Source=LAPTOP-H8F30CQH\SQLEXPRESS;Initial Catalog=PBL;Integrated Security=True";
        }
       
        SqlConnection con = new SqlConnection();

    }
}
