namespace CalculateStatistics
{
    internal class Program
    {
        //Task11: Calculate Statistics
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 54, 7, 8, 9, 10, 11, 12, 13 };
            int sum, average, max;

            CalculateStatistics(array, out sum, out average, out max);
            Console.WriteLine("Sum is = {0}, Average is {1}, Max is {2}", sum, average, max);
        }

        static void CalculateStatistics(int[] array, out int sum, out int average, out int max)
        {
            sum = array.Sum();
            average = sum / array.Length;
            max = array.Max();
        }
    }
}
