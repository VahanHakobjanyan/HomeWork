using System.Collections.Generic;

namespace Generate_the_Fibonacci_sequence
{
    internal class Program
    {
        //Generate the Fibonacci sequence using yield return.
        //Create an iterator that produces Fibonacci numbers up to a specified limit.
        //Example: foreach (var fib in FibonacciSequence(100)) { Console.Write(fib + " "); }.
        static void Main(string[] args)
        {
            int numberToStop = 22;
            FibonacciSequence sequence = new FibonacciSequence(numberToStop);

            foreach (var num in sequence)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
