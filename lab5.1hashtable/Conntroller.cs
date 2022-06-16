using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._1way2
{
   
    class Conntroller
    {
      
        //ReadData 
        public void RealAllPr()
        {
            ConnectionDb connectionDb=new ConnectionDb();
            SqlConnection sqlConnection = connectionDb.GetConnection();
            string query = "select * from product";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Hashtable hashtable = new Hashtable();
            while (reader.Read())
            {
                Product product = new Product((string)reader[1], (string)reader[2], (decimal)reader[3]);
                hashtable.Add(reader[0],product);
            }
           foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key+" "+entry.Value);
            }
            sqlConnection.Close();
        }
        public void SearchByName()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection sqlConnection=connectionDb.GetConnection();
            string query = "select^*from product where proName=@proName";
            Console.WriteLine("Enter the product name you want to search");
            string proName = Console.ReadLine();
            sqlConnection.Open();
            SqlCommand sqlCommand=new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@proName",proName);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader.GetString(0),sqlDataReader.GetString(1),sqlDataReader.GetDecimal(2));
            }
        }
        public void SearchById()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection sqlConnection = connectionDb.GetConnection();
            string query = "select^*from product where id=@id";
            Console.WriteLine("Enter the product id you want to search");
            int id = int.Parse(Console.ReadLine());
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader.GetString(0), sqlDataReader.GetString(1), sqlDataReader.GetDecimal(2));
            }
        }
        public void CreatePr()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection sqlConnection = connectionDb.GetConnection();
            Console.WriteLine("Enter your product Name ");
            string proName = Console.ReadLine();
            Console.WriteLine("Enter your product Description ");
            string proDesc = Console.ReadLine();
            Console.WriteLine("Enter your product price ");
            decimal price = decimal.Parse(Console.ReadLine());
            string query = "insert into product[proName,proDesc,price] values(@proName,@proDesc,@price)";
            sqlConnection.Open();
            SqlCommand sqlCommand= new SqlCommand(query, sqlConnection);
            int row = sqlCommand.ExecuteNonQuery();
            Console.WriteLine(row);
            Console.WriteLine("Insert succesful product");
            sqlConnection.Close();

        }
        public void EditProduct()
        {
            int choose;
            do
            {
                Console.WriteLine("Where you want to edit");
                Console.WriteLine("1.  product name");
                Console.WriteLine("2.  product description");
                Console.WriteLine("3.  product price");

                Console.WriteLine("4.  Exit ");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please enter your selection");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:

                        EditProductName();
                        break;

                    case 2:
                        EditProductDescription();
                        break;
                    case 3:
                        EditProductPrice();
                        break;

                    case 4:
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choose != 4);
        }
        static void EditProductName()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            Console.WriteLine("Enter product Id you want to edit product name:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your new product name :");
            string proName = Console.ReadLine();
            string query = "update product set proName=@proName where id=@id";

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@proName", proName);
            int row = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("update successful product");
            connection.Close();
        }
        static void EditProductDescription()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            Console.WriteLine("Enter product Id you want to edit product description:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your new product description :");
            string proDesc = Console.ReadLine();
            string query = "update product set proDesc=@proDesc where id=@id";

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@proDesc", proDesc);
            int row = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("update successful product");
            connection.Close();
        }
        static void EditProductPrice()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            Console.WriteLine("Enter product Id you want to edit product price:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your new product price :");
            decimal price = decimal.Parse(Console.ReadLine());
            string query = "update product set proName=@proName where id=@id";

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@price", price);
            int row = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("update successful product");
            connection.Close();
        }
        public void DeleteProduct()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            Console.WriteLine("Enter the product id you want to delete");
            int id = int.Parse(Console.ReadLine());
            string query = "delete product where id=@id";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            int row = sqlCommand.ExecuteNonQuery();
            
            Console.WriteLine("Delete successful product");

            connection.Close();
        }
    }
}
