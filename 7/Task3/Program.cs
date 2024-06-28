namespace Task3
{
    internal class Program
    {
        //Task 3: Average of Numbers
        static void Main(string[] args)
        {
            int[] numbers = new int[50];

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Enter {0}th number", i + 1);
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Average of 50 numbers is {0}", sum / 50);

            Console.ReadKey();
        }
    }
}
