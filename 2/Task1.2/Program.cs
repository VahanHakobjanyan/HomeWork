namespace Task1._2
{
    internal class Program
    {
        //Task 1.2: User Information (Same Line)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your profession");
            string profession = Console.ReadLine();

            Console.Write($"name - {name}, ");
            Console.Write($"surname - {surname}, ");
            Console.Write($"{age} years old, ");
            Console.Write($"works as {profession}.");

            Console.ReadKey();
        }
    }
}
