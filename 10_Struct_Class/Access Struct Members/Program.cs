using System;

namespace Access_Struct_Members
{
    internal class Program
    {
        //Access Struct Members: Given a Person instance, print out its FirstName, LastName, and Age.

        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Age = 30;

            Console.WriteLine("Name - {0}\nLastName - {1}\nAge - {2}", person.FirstName, person.LastName, person.Age);

            Console.ReadKey();
        }
    }

    struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
