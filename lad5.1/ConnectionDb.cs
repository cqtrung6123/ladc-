using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad5._1
{
    public class ConnectionDb
    {
        public SqlConnection GetConnection()
        {

            string connectionString = "Data source = localhost;Initial Catalog=myjdbapp;User=sa;password=Quoctrung61";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
