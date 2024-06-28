namespace Task7
{
    internal class Program
    {
        //Task 7: Sum of Even Digits
        static void Main(string[] args)
        {
            int userNumber = 0;
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out userNumber);

            int sum = 0;
            int currentDigit = 0;
            int length = userNumber.ToString().Length;

            for (int i = 0; i < length; i++)
            {
                currentDigit = (userNumber % 10);

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }

                userNumber -= currentDigit;
                userNumber /= 10;
            }

            Console.WriteLine("Sum of even digits is {0}", sum);

            Console.ReadKey();
        }
    }
}
