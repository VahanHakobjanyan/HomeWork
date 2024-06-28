namespace Find_Maximum_with_out
{
    internal class Program
    {
        //Task6: Find Maximum with out
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 9, 54, 3, 2, - 7, 0 };
            int max;

            int numbersCount = FindMaximumWithOut(numbers, out max);

            Console.WriteLine($"Out of {numbersCount} numbers maximum is {max}");
        }

        static int FindMaximumWithOut(int[] numbers, out int max)
        {
            max = numbers.Max();
            return numbers.Length;
        }
    }
}
