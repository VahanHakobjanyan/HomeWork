namespace Task10
{
    internal class Program
    {
        //Task 10: Sum of Digits
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out number);

            int digitCount = number.ToString().Length;
            int sum = 0;
            int lastDigit = 0;

            for (int i = 0; i < digitCount; i++)
            {
                lastDigit = number % 10;
                sum += lastDigit;
                number = (number - lastDigit) / 10;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
