using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Task6
{
    internal class Program
    {
        //Define a delegate that takes an integer and returns a boolean.
        //Create a custom Where method that mimics the LINQ Where method.
        //Use the custom Where method to filter a list of integers.

        delegate bool Filter(in int number, out bool result);

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 12, 32, -12, -3, 4, 1, 5, 324, 65, 0, -2 };

            List<int> lessThanZero = list.CustomWhere(x => x < 0).ToList();

            foreach (int number in lessThanZero)
            {
                Console.WriteLine(number);
            }
        }
    }
}
