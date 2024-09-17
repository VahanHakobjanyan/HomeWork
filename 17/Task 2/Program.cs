using System;

namespace Task_2
{
    //Define a delegate that takes a string and returns void.
    //Create an anonymous method that prints the string to the console.
    //Invoke the delegate with a sample string.

    internal class Program
    {
        delegate void Printer(string text);

        static void Main(string[] args)
        {
            Printer printer = delegate (string text)
            {
                Console.WriteLine("Text to print - {0}", text);
            };

            printer("Sample text");
        }
    }
}
