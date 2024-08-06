using System;

namespace Custom_Range_Generator
{
    internal class Program
    {
        //Custom Range Generator:
        //Create a custom range generator using yield return.
        //The generator should take a start value and an end value and produce all integers in that range.
        //Example usage: foreach (var number in RangeGenerator(5, 10)) { Console.Write(number + " "); }
        //should output 5 6 7 8 9 10

        static void Main(string[] args)
        {
            RangeGenerator generator = new RangeGenerator(5, 10);

            foreach (var number in generator)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
