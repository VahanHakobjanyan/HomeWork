namespace Rectangle_Struct
{
    internal class Program
    {
        //Rectangle Struct: Define a Rectangle struct with fields for width, height, and a Point representing the top-left corner.
        //Implement methods to calculate area and perimeter
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.width = 12;
            rectangle.height = 6;

            Console.WriteLine("Area = {0}", rectangle.Area());
            Console.WriteLine("Perimeter = {0}", rectangle.Perimeter());

            Console.ReadKey();
        }
    }

    struct Rectangle
    {
        public double width { get; set; }
        public double height { get; set; }
        Point topLeft { get; set; }

        public double Area()
        {
            return width * height;
        }
        public double Perimeter()
        {
            return 2 * (width + height);
        }
    }

    struct Point
    {
        public double X { get; init; }
        public double Y { get; init; }
    }
}
