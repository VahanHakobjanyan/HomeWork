namespace Task7
{
    internal class Program
    {
        //Task 7: Trimming Strings
        static void Main(string[] args)
        {
            string greeting = "  Hello, World!  ";
            Console.Write("Before trimming - {0}", greeting);

            Console.WriteLine("After trimming - {0}", greeting.Trim());

            Console.ReadKey();
        }
    }
}
