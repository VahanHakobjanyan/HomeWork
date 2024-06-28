namespace Task8
{
    internal class Program
    {
        //Task 8: Generate Random Numbers
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(1, 100) + " ");
            }

            Console.ReadKey();
        }
    }
}
