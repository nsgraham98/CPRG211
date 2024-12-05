using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DemoMod9SqliteNoExtension.Data
{
    public class ProductInfo
    {
        [PrimaryKey, AutoIncrement]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdQty { get; set; }
        public int ProdPrice { get; set; }
    }
}
