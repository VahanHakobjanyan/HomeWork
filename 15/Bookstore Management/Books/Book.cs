using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Management.Books
{
    public class Book
    {
        public string Title { get; }
        public string Authors { get; }
        public string ISBN { get; }
        public decimal Price { get; set  /*TODO*/; }
        public string Description { get; }
        public Category Category { get; }

        private int _stockQuantity;
        private bool _inStock => _stockQuantity > 0;

        public Book(string title, string authors, string isbn, decimal price, int stockQuantity, string desc, Category category)
        {
            Title = title;
            Authors = authors;
            ISBN = isbn;
            Price = price;
            _stockQuantity = stockQuantity;
            Description = desc;
            Category = category;
        }

        public override string ToString()
        {
            return $"Title - {Title}, Author(s) - {Authors}, Category - {Category}\n{Description}.\nPrice - {Price}";
        }
    }
}

