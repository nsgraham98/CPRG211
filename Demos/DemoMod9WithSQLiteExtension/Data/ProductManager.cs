using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9WithSQLiteExtension.Data
{
	public class ProductManager
	{
		// ProductManager defines various operations like add, delete, edit, select (retrieve)
		public static List<Product> products;

		public static string AddProduct(int prodId, string prodName, int prodQty, int prodPrice)
		{
			return "";
		}

		public static List<Product> RetrieveProduct()
		{
			return products;
		}

		public static string EditProduct(int prodId, string prodName, int prodQty, int prodPrice)
		{
			return "";
		}

		public static string DeleteProduct(int prodId)
		{
			return "";
		}

	}
}
