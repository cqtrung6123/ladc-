using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Collections;
using System.Data;

namespace lad5._1
{
    public class Controller
    {
  //them  ban ghi     
        public void CreateProduct()
        {
           
            
            
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            
            Console.WriteLine("enter product name");
            string proName = Console.ReadLine();
            Console.WriteLine("enter product desc");
            string proDesc = Console.ReadLine();
            Console.WriteLine("enter product price");
            decimal price = decimal.Parse(Console.ReadLine());
           
            string query = "insert into product(proName,proDesc,price) values(@proName,@proDesc,@price)";
            
            connection.Open();
           
            SqlCommand sqlCommand = new SqlCommand(query,connection);

            sqlCommand.Parameters.AddWithValue("@proName",proName);

            sqlCommand.Parameters.AddWithValue("@proDesc",proDesc);

            sqlCommand.Parameters.AddWithValue("@price",price);
           
            var count= sqlCommand.ExecuteNonQuery();
            ConsoleColor color = ConsoleColor.Green;
            Console.WriteLine(" Add successful product",color);
            connection.Close(); 
        }

//sua ban ghi
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
            } while (choose!=4);
        }
         static void EditProductName()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            Console.WriteLine("Enter product Id you want to edit product name:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your new product name :");
            string proName= Console.ReadLine();
            string query = "update product set proName=@proName where id=@id";
            
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@proName", proName);
            int row=sqlCommand.ExecuteNonQuery();
            ConsoleColor consoleColor = ConsoleColor.Green;
            Console.WriteLine("update successful product",consoleColor);
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
            ConsoleColor consoleColor = ConsoleColor.Green;
            Console.WriteLine( "update successful product", consoleColor);
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
            ConsoleColor consoleColor = ConsoleColor.Green;
            Console.WriteLine("update successful product", consoleColor);
            connection.Close();
        }


        //tim kiem product theo id
        public  void SearchProductById()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            string query = "select*from product where id=@id";
            int id = int.Parse(Console.ReadLine());
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.ToString());
            }

            connection.Close();

        }
        //xoa product theo id

        public void DeleteById()
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
            ConsoleColor color = ConsoleColor.Green;
            Console.WriteLine("Delete successful product",color);
           
            connection.Close();
        }
        
       //lay ra danh sach product
        public void GetAllProduct()
        {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            string query = "select*from product";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader=sqlCommand.ExecuteReader();
            List<Product> productlist = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product( reader.GetString(1), reader.GetString(2), reader.GetDecimal(3));
                productlist.Add(product);
            }
            foreach (Product product in productlist)
            {
                Console.WriteLine(product.ToString());
            }
            connection.Close();

        }
        // tim kiem theo ten
        public void SearchProductByName() {
            ConnectionDb connectionDb = new ConnectionDb();
            SqlConnection connection = connectionDb.GetConnection();
            string query = "select*from product";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Product> productlist = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product(reader.GetString(1), reader.GetString(2), reader.GetDecimal(3));
                productlist.Add(product);
            }
            Console.WriteLine("enter product proName");
            string name = Console.ReadLine();
            foreach (Product product in productlist)
            {
                if(product.proName.Contains(name))
                Console.WriteLine(product.ToString());
                else
                {
                    Console.WriteLine("not found");
                    break;
                }
            }
            
            connection.Close();
        }
     
    }
}
