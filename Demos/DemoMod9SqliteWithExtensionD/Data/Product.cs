using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DemoMod9SqliteWithExtensionD.Data
{
    public class Product
    {
        int prodId;
        string prodName;
        int prodQty;
        int prodPrice;

        [PrimaryKey, AutoIncrement]
        public int ProdId { get => prodId; set => prodId = value; }
        public string ProdName { get => prodName; set => prodName = value; }
        public int ProdQty { get => prodQty; set => prodQty = value; }
        public int ProdPrice { get => prodPrice; set => prodPrice = value; }

        public Product()
        {
            
        }

        public Product(int prodId, string prodName, int prodQty, int prodPrice)
        {
            this.ProdId = prodId;
            this.ProdName = prodName;
            this.ProdQty = prodQty;
            this.ProdPrice = prodPrice;
        }
    }
}
