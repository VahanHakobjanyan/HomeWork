namespace Nested_Structs
{
    internal class Program
    {
        //Nested Structs: Create a struct called Address with fields for street, city, and postal code.
        //Then create a Person struct with an Address field.

        static void Main(string[] args)
        {
            Address address = new Address()
            {
                City = "Yerevan",
                Street = "Arshakunyac",
                PostalCode = "035"
            };
            Person person = new Person("John", "Doe", 25, address);
        }
    }

    struct Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

    }

    struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        Address Address { get; set; }

        public Person(int age)
        {
            Age = age;
        }
        public Person(string firstName, string lastName, int age, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
