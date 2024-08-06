using Bookstore_Management.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Management
{
    internal class Admin
    {
        public bool isAdmin { get; }
        public Admin()
        {
            isAdmin = true;
        }

        public void AddBookToInventory(Inventory inventory, Book book)
        {
            inventory.AddToInventory(this, book);
        }
        public void UpdateBookInfo()
        {
            throw new NotImplementedException();
        }
    }
}
