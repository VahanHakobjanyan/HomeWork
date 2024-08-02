using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Bookshelf
{
    internal class Book
    {
        public string Name { get; }
        public int ReleaseYear { get; }

        public Book(string name, int releaseYear)
        {
            Name = name;
            ReleaseYear = releaseYear;
        }

        public override string ToString()
        {
            return $"Book name - {Name}, Release year - {ReleaseYear}";
        }
    }
}
