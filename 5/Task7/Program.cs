namespace Task7
{
    internal class Program
    {
        //Task 7: Complex Nested if Statements
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age");
            int age = 20;
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Have license? (True or False)");
            bool hasLicense = false;
            bool.TryParse(Console.ReadLine(), out hasLicense);

            if (age >= 18)
            {
                if (hasLicense)
                    Console.WriteLine("Can drive");
                else
                    Console.WriteLine("Can not driver");
            }
            else
                Console.WriteLine("Can not drive");

            Console.ReadKey();
        }
    }
}
