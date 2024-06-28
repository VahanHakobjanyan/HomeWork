namespace CalculateRectangleProperties
{
    internal class Program
    {
        //Task14: Create a method called CalculateRectangleProperties that takes the length and width of a rectangle and returns its area and perimeter.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int perimeter;

            int area = CalculateRectangleProperties(12, 10, out perimeter);

            Console.WriteLine("Area is {0}, Perimeter is {1}", area, perimeter);
        }

        static int CalculateRectangleProperties(int length, int width, out int perimeter)
        {
            perimeter = 2 * (length + width);
            return length * width;
        }
    }
}
