using Bookstore_Management.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Management
{
    internal class Inventory
    {
        public List<Book> BookInventory;
        private List<Admin> _admins = new List<Admin>();

        public Inventory(Admin admin)
        {
            BookInventory = new List<Book>();
            _admins.Add(admin);
        }
        public void ShowAllStock(Category categories)
        {
            if (categories.HasFlag(Category.None))
            {
                foreach (var book in BookInventory)
                {
                    Console.WriteLine(book.Title + " " + book.Authors);
                }
            }
        }
        public void ShowByCategory(Category categories)
        {
            foreach (var book in BookInventory)
            {
                if (book.Category.HasFlag(categories))
                {
                    Console.WriteLine(book.Title + " " + book.Authors);
                }
            }

        }

        public void AddAdmin(Admin admin)
        {
            _admins.Add(admin);
        }

        public void AddToInventory(Admin admin, Book book)
        {
            if (!admin.isAdmin)
            {
                Console.WriteLine("You dont have permission to do that");
            }
            else
            {
                BookInventory.Add(book);
            }
        }
    }
}
