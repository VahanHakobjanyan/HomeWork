namespace Nth_Fibonacci_number
{
    internal class Program
    {
        //Task8: Write a recursive function to calculate the Nth Fibonacci number
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciNumber(10));
        }

        static int FibonacciNumber(int position)
        {
            if (position == 1)
            {
                return 0;
            }
            else if (position == 2)
            {
                return 1;
            }
            else return (FibonacciNumber(position - 1) + FibonacciNumber(position - 2));
        }
    }
}
