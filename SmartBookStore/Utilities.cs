using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore
{
    public class Utilities
    {
        public static void BookAdd(Book book)
        {
            GlobalVariables.cart.Books.Add(book);
        }

        public static void BookDelete(string title)
        {
            Book bookToDelete = new Book();
            foreach (Book book in GlobalVariables.cart.Books)
            {
                if (book.Title == title)
                {
                    bookToDelete = book;
                    break;
                }
            }
            GlobalVariables.cart.Books.Remove(bookToDelete);
        }
    }
}
