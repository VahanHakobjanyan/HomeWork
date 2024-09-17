using System.Text.RegularExpressions;

namespace Task_1
{
    internal class Program
    {
        //Define a delegate that takes two integers and returns an integer.
        //Create two methods that match the delegate signature: one for addition and one for multiplication.
        //Instantiate the delegate with each method and invoke it.

        delegate int Calculator(int x, int y);
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            Calculator add = methods.Addition;  
            Calculator multiply = methods.Multiplier;

            Console.WriteLine(add(10, 5));
            Console.WriteLine(multiply(10, 5));
        }
    }

    public class Methods
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Multiplier(int a, int b)
        {
            return a * b;
        }
    }
}
