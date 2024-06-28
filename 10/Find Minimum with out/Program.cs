namespace Find_Minimum_with_out
{
    internal class Program
    {
        //Task1: Find Minimum with out
        static void Main(string[] args)
        {
            double[] numbers = { 3.23, 765.456, 34 };
            double min;
            FindMinimumWithOut(numbers, out min);

            Console.WriteLine(min);
        }

        static void FindMinimumWithOut(double[] doubles, out double min)
        {
            min = doubles.Min();
        }
    }
}
