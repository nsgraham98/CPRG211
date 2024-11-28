using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DemoMod9WithSQLiteExtension.Data
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

		private void CreateTableDB()
		{
			SQLiteConnection conn = new SQLiteConnection(connect_string);
			conn.Open();
			string sql = "Create table products1(ProdId integer(8) primary key), ProdName text(30), ProdQty integer(8), ProdPrice integer(8)";

			using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
			{
				cmd.ExecuteNonQuery();
			}

			conn.Close();
		}

		public List<Product> LoadProductFromDB()
		{
			//CreateTableDB();
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
						Product prod = new Product(ProdId, ProdName, ProdQty, ProdPrice);
						product_list.Add(prod);
					}
				}
			}
			connection.Close();
			return product_list;
		}

	}
}
