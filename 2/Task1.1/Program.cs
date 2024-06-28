namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1: User Information (Separate Lines)

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your profession");
            string profession = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Surname is {surname}");
            Console.WriteLine($"{age} years old");
            Console.WriteLine($"Works as {profession}");

            Console.ReadKey();
        }
    }
}
