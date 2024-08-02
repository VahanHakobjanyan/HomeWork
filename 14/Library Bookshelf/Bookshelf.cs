using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Bookshelf
{
    internal class Bookshelf : IEnumerable, IEnumerator
    {
        int _capacity;
        int _position = -1;
        int bookCount = 0;

        List<Book> books;

        public Bookshelf(int capacity)
        {
            _capacity = capacity;
            books = new List<Book>();
        }

        public Book GetBook(int index)
        {
            return books[index];
        }

        public void AddBook(Book newbook)
        {
            if (bookCount < _capacity)
            {
                books.Add(newbook);

            }
            else
            {
                Console.WriteLine("This shelf is full");
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position == _capacity - 1)
            {
                return false;
            }
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object Current
        {
            get { return books[_position]; }
        }
    }
}
