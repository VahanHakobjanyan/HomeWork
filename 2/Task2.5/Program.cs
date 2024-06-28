namespace Task2._5
{
    internal class Program
    {
        //Task 2.5:Try to print on the console Some interesting design
        static void Main(string[] args)
        {
            Console.WriteLine("Input side length");
            int side = int.Parse(Console.ReadLine());

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= side; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
