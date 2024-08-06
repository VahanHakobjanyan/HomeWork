using Bookstore_Management.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Management.Shopping_Cart
{
    internal class ShoppingCart
    {
        List<Book> cart = new List<Book>();

        public ShoppingCart()
        {
            cart = new List<Book>();
        }
        public void AddBook(Book book)
        {
            cart.Add(book);
        }
        public void RemoveBook(Book book)
        {
            cart.Remove(book);
        }
    }
}
