namespace Overload_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point() { X = 1, Y = 2 };
            Point point2 = new Point() { Y = 3, X = 4 };

            Point point3 = point1 + point2;

            Console.WriteLine($"Point1 - [{point1.X}, {point1.Y}]");
            Console.WriteLine($"Point1 - [{point2.X}, {point2.Y}]");
            Console.WriteLine($"Point1 - [{point3.X}, {point3.Y}]");

            Console.ReadKey();
        }
    }

    struct Point
    {
        public double X { get; init; }
        public double Y { get; init; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y ? true : false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static Point operator+ (Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}
