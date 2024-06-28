namespace Calculate_Average_with_out
{
    internal class Program
    {
        //Task4: Calculate Average with out
        static void Main(string[] args)
        {
            int average;
            int[] ints = { 1, 2, 3, 78 };
            CalculateAverageWithOut(ints, out average);
            Console.WriteLine(average);
        }

        static void CalculateAverageWithOut(int[] ints, out int average)
        {
            average = ints.Sum() / ints.Length;
        }
    }
}
