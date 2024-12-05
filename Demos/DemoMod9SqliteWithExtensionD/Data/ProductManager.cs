using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9SqliteWithExtensionD.Data
{
    public class ProductManager
    {
        //To define various operations like add, delete, update, select

        public static List<Product> products;

        public static string AddProduct(int prodId, string prodname, int prodQty, int prodPrice)
        {
            //return "";
            DBHandler db = new DBHandler();
            db.InsertProductDB(prodId, prodname, prodQty, prodPrice);
            return "Added Successfully";
        }

        public static List<Product> Retriveproduct()
        {
            //return products;
            DBHandler db = new DBHandler();
            products = db.LoadProductFromDB();
            return products;
        }

        public static string EditProduct(int prodId, string prodName, int prodQty, int prodPrice)
        {
            //return "";
            string message = DBHandler.UpdateProductToDB(prodId, prodName, prodQty, prodPrice);
            Retriveproduct();
            return message;
        }
        public static string DeleteProduct(int prodId)
        {
            //return "";
            DBHandler db = new DBHandler();
            string message = db.DeleteProductDB(prodId);
            Retriveproduct();
            return message;
        }
    }
}
