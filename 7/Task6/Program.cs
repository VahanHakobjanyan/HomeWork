namespace Task6
{
    internal class Program
    {
        //Task 6: Armstrong Number
        static void Main(string[] args)
        {
            int numberToCheck = 0;
            Console.WriteLine("Enter number to check");
            int.TryParse(Console.ReadLine(), out numberToCheck);

            int temp = numberToCheck;
            int digitCount = numberToCheck.ToString().Length;

            int[] digits = new int[digitCount];
            int currentDigit = 0;

            for (int i = 0; i < digitCount; i++)
            {
                currentDigit = temp % 10;
                digits[i] = currentDigit;
                temp = (temp - currentDigit) / 10;
            }

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], digitCount);
            }

            if (sum == numberToCheck)
            {
                Console.WriteLine("Number you entered is Armstrong number");
            }
            else
            {
                Console.WriteLine("Number you entered is not Armstrong number");
            }

            Console.ReadKey();
        }
    }
}
