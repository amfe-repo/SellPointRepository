using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Layers.Data
{
    public class Connection
    {
        protected static string strConn = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;
        protected static SqlConnection connection = new SqlConnection(strConn);
        protected SqlCommand command = new SqlCommand(); 

        public void OpenConnection() 
        {
            if(connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
