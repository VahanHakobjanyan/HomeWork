using Basic_Interface_Implementation.Shapes;
using System.Security.Authentication;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic_Interface_Implementation
{
    internal class Program
    {
        //Basic Interface Implementation:
        //Create an interface called IShape with a method CalculateArea().
        //Implement this interface in classes for different shapes(e.g., Circle, Rectangle, Triangle).
        //Each class should provide its own implementation of the area calculation.
        //Create instances of these shapes and calculate their areas.
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(5, 15);
            Triangle triangle = new Triangle(10, 7, 5);

            IShape[] shapes = [circle, rectangle, triangle];

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name} is {shape.CalculateArea()}");
            }

            Console.ReadKey();
        }
    }
}
