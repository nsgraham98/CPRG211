using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMod9MAUI.Data
{
    public class DBook
    {
        int bookId;
        string bookTitle;
        string bookAuthor;
        string price;
        string quantity;

        public DBook() { }
        public DBook(int bookId, string bookTitle, string bookAuthor, string price, string quantity)
        {
            BookId = bookId;
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            Price = price;
            Quantity = quantity;
        }

        public int BookId { get => bookId; set => bookId = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string Price { get => price; set => price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
    }
}
