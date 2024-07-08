namespace Create_Struct_Instances
{
    internal class Program
    {
        //Create Struct Instances: Declare and initialize three instances of the Person struct with different values for each field.
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.FirstName = "John";
            person1.LastName = "Doe";
            person1.Age = 30;

            person2.FirstName = "Jane";
            person2.LastName = "Dough";
            person2.Age = 23;

            person3.FirstName = "Scott";
            person3.LastName = "Ryan";
            person3.Age = 43;
        }
    }

    struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
