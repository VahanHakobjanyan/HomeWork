using System.Runtime.Intrinsics.X86;

namespace Custom_Struct_with_Methods
{
    internal class Program
    {
        //Custom Struct with Methods: Define a struct called Temperature that represents a temperature in Celsius.
        //It should have the following members:A field for the temperature value(e.g., double Celsius).
        //A method to convert the temperature to Fahrenheit(use the formula: Fahrenheit = Celsius * 9 / 5 + 32)
        static void Main(string[] args)
        {
            Temperature temp = new Temperature(22);
            Console.WriteLine("Its {0}C outside", temp.Celsius);

            Console.WriteLine("Its {0}F outside", temp.CovertToFarenheit(temp.Celsius));

            Console.ReadKey();
        }
    }

    struct Temperature
    {
        public double Celsius { get; set; }

        public Temperature(double celsius)
        {
            Celsius = celsius;
        }

        public double CovertToFarenheit(double celsius)
        {
            return Celsius * 9 / 5 + 32;
        }
    }
}
