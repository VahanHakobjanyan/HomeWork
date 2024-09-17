using System.Text.RegularExpressions;

namespace Task_4
{
    internal class Program
    {
        //Define a delegate that takes no parameters and returns void.
        //Create two methods that match the delegate signature: one that prints “Hello” and one that prints “World”.
        //Combine the methods into a multicast delegate and invoke it.

        delegate void Printer();

        static void Main(string[] args)
        {
            Printer printer = printHello;
            printer += printWorld;

            printer.Invoke();
        }

        static void printHello()
        {
            Console.WriteLine("Hello");
        }

        static void printWorld()
        {
            Console.WriteLine("World");
        }
    }
}
