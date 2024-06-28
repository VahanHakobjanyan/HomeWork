namespace Task2
{
    internal class Program
    {
        //Task 2: if-else Statement
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Enter the number to check");
            int.TryParse(Console.ReadLine(), out number);

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            Console.ReadKey();
        }
    }
}
