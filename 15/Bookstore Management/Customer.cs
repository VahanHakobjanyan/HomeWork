using Bookstore_Management.Books;
using Bookstore_Management.Shopping_Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Management
{
    internal class Customer
    {
        ShoppingCart cart;
        List<Book> orderHistory;
        public Customer()
        {
            cart = new ShoppingCart();
        }
        public void BrowseAll(Inventory shop)
        {
            shop.ShowAllStock(Category.None);
        }
        public void BrowseByCategory(Inventory shop, Category category)
        {
            shop.ShowByCategory(category);
        }
        public void ViewBook(Book book)
        {
            Console.WriteLine(book);
        }
        public void AddToCart(Book book)
        {
            cart.AddBook(book);
        }
        public void RemoveFromCart(Book book)
        {
            cart.RemoveBook(book);
        }

        public void PlaceOrder(Book book, Inventory shop)
        {
            throw new NotImplementedException();
        }

        public void ShowOrderHistory()
        {
            foreach (var book in orderHistory)
            {
                Console.WriteLine(book);
            }
        }
    }
}
