namespace Task1
{
    internal class Program
    {
        //Task 1: Find the Largest Number
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter {0}th number", i + 1);
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Max is {0}", max);

            Console.ReadKey();
        }
    }
}
