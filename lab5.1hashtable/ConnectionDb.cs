using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._1way2
{
     class ConnectionDb
    {
        public SqlConnection GetConnection()
        {
            string connectionstring = "Data source = localhost;Initial Catalog=myjdbapp;User=sa;password=Quoctrung61";
            SqlConnection sqlConnection=new SqlConnection(connectionstring);
            return sqlConnection;
        }
    }
}
