using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DemoMod9SqliteWithExtensionD.Data
{
    public class DBHandler
    {
        static List<Product> product_list = new List<Product>();

        static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string dbPath = Path.Combine(baseDirectory, "products.db");
        static string connect_string = $"Data Source={dbPath}";

        public DBHandler()
        {
           //CreateTableDB();
            LoadProductFromDB();
        }

        protected bool IsTableExist()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connect_string))
            {
                connection.Open();
                string sql = $"Select name from sqlite_master where type='table' and name='products1';";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
        }
        private void CreateTableDB()
        {
            if (!IsTableExist())
            {
                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = "Create table products1(ProdId INTEGER(8) PRIMARY KEY, ProdName TEXT(30), ProdQty INTEGER(8), ProdPrice INTEGER(8))";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }

        }

        public List<Product> LoadProductFromDB()
        {
            // CreateTableDB();
            product_list.Clear();
            SQLiteConnection connection = new SQLiteConnection(connect_string);
            connection.Open();
            string sql = "Select * from products1";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            using (cmd)
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ProdId = reader.GetInt32(0);
                        string ProdName = reader.GetString(1);
                        int ProdQty = reader.GetInt32(2);
                        int ProdPrice = reader.GetInt32(3);
                        Product product = new Product(ProdId, ProdName, ProdQty, ProdPrice);
                        product_list.Add(product);
                    }
                }
            }
            connection.Close();
            return product_list;

        }

        //Retrieve next available ProdId for inserting a new record
        public int GetNextId()
        {
            int res = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connect_string))
            {
                connection.Open();
                string selectQuery = "Select MAX(ProdId) AS MaxId from products1";
                using (SQLiteCommand selectCmd = new SQLiteCommand(selectQuery, connection))
                {
                    var result = selectCmd.ExecuteScalar();
                    return result == DBNull.Value ? 1 : Convert.ToInt32(result) + 1;
                    connection.Close();
                }
                
            }
            
        }
        //Insert a product
        public void InsertProductDB(int ProdId, string ProdName, int ProdQty, int ProdPrice)
        {
            SQLiteConnection connection = new SQLiteConnection(connect_string);
            connection.Open();
            int newId = GetNextId();
            string sql = $"INSERT into products1 values(@pId, @pName, @pQty, @pPrice)";
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            using (cmd)
            {
                cmd.Parameters.AddWithValue("@pId", newId);
                cmd.Parameters.AddWithValue("@pName", ProdName);
                cmd.Parameters.AddWithValue("@pQty", ProdQty);
                cmd.Parameters.AddWithValue("@pPrice", ProdPrice);
                cmd.ExecuteNonQuery(); //Forgot to add this
            }
            connection.Close();

        }

        //Update Product
        public static string UpdateProductToDB(int prodId, string new_pname, int new_pqty, int new_price)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = "Update products1 set ProdName=@new_pname, ProdQty=@new_pqty, ProdPrice=@new_price WHERE ProdId=@prodId ";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@new_pname", new_pname);
                    cmd.Parameters.AddWithValue("@new_pqty", new_pqty);
                    cmd.Parameters.AddWithValue("@new_price", new_price);
                    cmd.Parameters.AddWithValue("@prodId", prodId);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return "Updated Successfully";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //Delete Product
        public string DeleteProductDB(int prodId)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connect_string);
                connection.Open();
                string sql = "Delete from products1 WHERE ProdId=@prodId ";
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@prodId", prodId);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return "Deleted  Successfully";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
