using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore
{
    public class CartItems
    {
        public List<Book> Books {get; set;}

        public CartItems()
        {
            Books = new List<Book>();
        }
    }
}
