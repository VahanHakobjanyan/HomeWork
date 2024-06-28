namespace Task5
{
    internal class Program
    {
        //Task 5: Print Even Numbers
        static void Main(string[] args)
        {
            int rangeStart = 0, rangeEnd = 0;

            Console.WriteLine("Enter two integers");
            int.TryParse(Console.ReadLine(), out rangeStart);
            int.TryParse(Console.ReadLine(), out rangeEnd);

            for (int i = rangeStart; i < rangeEnd + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
