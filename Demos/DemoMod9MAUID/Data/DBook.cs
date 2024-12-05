using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9MAUID.Data
{
    public class DBook
    {
        int bookID;
        string booktitle;
        string bookauthor;
        int price;
        int quantity;

        public int BookID { get => bookID; set => bookID = value; }
        public string Booktitle { get => booktitle; set => booktitle = value; }
        public string Bookauthor { get => bookauthor; set => bookauthor = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public DBook()
        {
            
        }

        public DBook(int bookID, string booktitle, string bookauthor, int price, int quantity)
        {
            this.BookID = bookID;
            this.Booktitle = booktitle;
            this.Bookauthor = bookauthor;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
