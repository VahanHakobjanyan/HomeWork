namespace Task2._3
{
    internal class Program
    {
        //Task 2.3: Change Console Title
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to change Console title");
            Console.ReadKey();
            Console.Title = "Test";
            Console.WriteLine("Title changed");

            Console.ReadKey();
        }
    }
}
