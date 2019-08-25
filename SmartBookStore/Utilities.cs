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
    }
}
