namespace Task2
{
    internal class Program
    {
        //Task 2: Sum of First N Natural Numbers
        static void Main(string[] args)
        {
            int sum = 0;
            int N = 0;
            int counter = 1;

            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out N);

            while (counter <= N)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
