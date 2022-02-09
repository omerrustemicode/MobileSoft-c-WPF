using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSHop_Soft.myclass
{
    class connections
    {
        SqlConnection conn;
        public connections(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
        public bool isConnection
        {
            get
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return true;
            }
        }
    }
}
