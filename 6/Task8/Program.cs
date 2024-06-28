namespace Task8
{
    internal class Program
    {
        //Task 8: Prime Numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int rangeStart = 0;
            int.TryParse(Console.ReadLine(), out rangeStart);
            int rangeEnd = 0;
            int.TryParse(Console.ReadLine(), out rangeEnd);

            for (int i = rangeStart; i < rangeEnd + 1; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    Console.Write(i + " ");
                    continue;
                }
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
