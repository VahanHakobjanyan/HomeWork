namespace Equality_Comparison
{
    internal class Program
    {
        //Equality Comparison: Implement equality comparison (== and !=) for the Point struct

        static void Main(string[] args)
        {
            Point point1 = new Point() { X = 1, Y = 2 };
            Point point2 = new Point() { Y = 3, X = 4 };
            Point point3 = new Point() { X = 1, Y = 2 };

            Console.WriteLine("Expected output - FALSE");
            Console.WriteLine(point1 == point2);

            Console.WriteLine("Expected output - TRUE");
            Console.WriteLine(point1 == point3);

            Console.ReadKey();
        }
    }

    struct Point
    {
        public double X { get; init; }
        public double Y { get; init; }

        public static bool operator== (Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y ? true : false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }
}
