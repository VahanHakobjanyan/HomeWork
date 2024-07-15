namespace Immutable_Struct
{
    internal class Program
    {
        //Immutable Struct: Design an immutable struct called Point representing a 2D point with double X and double Y coordinates

        static void Main(string[] args)
        {
            Point point = new Point() { X = 8, Y = 25 };

            Console.WriteLine($"X = {point.X}, Y = {point.Y}");

            Console.ReadKey();
        }
    }

    struct Point
    {
        public Point( int x, int y )
        {
            X = x;
            Y = y;
        }
        public double X { get; init; }

        public double Y { get; init; }
    }
}
