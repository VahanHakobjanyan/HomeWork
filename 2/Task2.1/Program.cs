namespace Task2._1
{
    internal class Program
    {
        //Task 2.1: Change Console Background and Foreground Color
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to change background color");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Background color is now Blue\n");
            Console.WriteLine("Press any key to change foreground color\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Foreground color is now red");

            Console.ReadKey();
        }
    }
}
