using System.Drawing;

namespace Task1
{
    internal class Program
    {
        //Task 1: Create an abstract class called Shape:
        //Define an abstract class named Shape with an abstract method CalculateArea(). This method should return the area of the shape(e.g., circle or rectangle).
        //Derive two classes from Shape: Circle and Rectangle.
        //Implement the CalculateArea() method in each derived class by providing the appropriate formulas for calculating the area of a circle and a rectangle.
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(10), new Rectangle(5, 13) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}`s area is {shape.CalculateArea()}");
            }

            Console.ReadKey();
        }
    }
}
