using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DemoMod9SQLiteWithoutExtension.Data
{
	public class ProductInfo
	{
		[PrimaryKey, AutoIncrement]
		public int ProdId { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }


	}
}
