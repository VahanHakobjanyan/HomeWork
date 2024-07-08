namespace Calculate_Average_Age
{
    internal class Program
    {
        //Calculate Average Age: Create an array of Person instances and calculate the average age of all people.

        static void Main(string[] args)
        {
            Person[] people = new Person[10];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(int.Parse(Console.ReadLine()));
            }

            int sum = 0;

            foreach (Person person in people)
            {
                sum += person.Age;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

    struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
