using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3
{
    internal class Program
    {
        //Define a delegate that takes a double and returns a double.
        //Create a lambda expression that squares the input number.
        //Invoke the delegate with a sample number.

        delegate double Square(double x);

        static void Main(string[] args)
        {
            double number = default;

            Console.WriteLine("Enter number to square");
            double.TryParse(Console.ReadLine(), out number);

            Square square = x => x * x;

            Console.WriteLine(square.Invoke(number));
        }
    }
}
