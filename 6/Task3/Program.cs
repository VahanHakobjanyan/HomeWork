namespace Task3
{
    internal class Program
    {
        //Task 3: Multiplication Table
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" {0}", (j + 1) * (i + 1));
                }
            }

            Console.ReadKey();
        }
    }
}
