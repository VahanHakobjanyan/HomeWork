using System.Reflection.Metadata;

namespace Library_Bookshelf
{
    internal class Program
    {
        //Imagine a library with many bookshelves. Each bookshelf contains books (our attractions).
        //The entire library represents a collection of attractions.
        //IEnumerable is like a librarian who hands you one book at a time (using an IEnumerator).
        //You can read each book(access its content) without loading the entire library into memory.

        static void Main(string[] args)
        {
            Bookshelf bookshelf = new Bookshelf(5);

            bookshelf.AddBook(new Book("book1", 1989));
            bookshelf.AddBook(new Book("book2", 2000));
            bookshelf.AddBook(new Book("book3", 1950));
            bookshelf.AddBook(new Book("book4", 2010));
            bookshelf.AddBook(new Book("book5", 2011));
            bookshelf.AddBook(new Book("book6", 1989));

            foreach (var book in bookshelf)
            {
                Console.WriteLine(book);
            }

            //get any book
            Console.WriteLine(bookshelf.GetBook(1));
        }
    }
}
