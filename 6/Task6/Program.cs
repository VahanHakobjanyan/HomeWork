namespace Task6
{
    internal class Program
    {
        //Task 6: Find Factorial
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int numberToCheck = 0;
            int.TryParse(Console.ReadLine(), out numberToCheck);

            int factorial = 1;

            for (int i = 0; i < numberToCheck; i++)
            {
                factorial *= i + 1;
            }

            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
