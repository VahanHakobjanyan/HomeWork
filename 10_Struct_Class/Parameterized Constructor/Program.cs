using System.Reflection.Metadata;

namespace Parameterized_Constructor
{
    internal class Program
    {
        //Parameterized Constructor: Add a parameterized constructor to the Person struct that
        //accepts values for FirstName, LastName, and Age.
        static void Main(string[] args)
        {
            Person person = new Person("John", "Doe", 30);
        }
    }

    struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
