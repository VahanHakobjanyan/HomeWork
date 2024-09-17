using System.Buffers.Text;
using System.Collections.Generic;

namespace Task8
{
    internal class Program
    {
        //Define a delegate that takes two objects of a custom class and returns a boolean.
        //Create a method that sorts a list of custom objects based on the delegate.
        //Implement delegates for sorting by a specific property in ascending and descending order.

        delegate bool PointComparer(Point p1, Point p2);

        static void Main(string[] args)
        {
            PointComparer comparer = (p1, p2) => p1.X > p2.X && p1.Y > p2.Y;

            List<Point> points = new List<Point> { new Point(1, 4), new Point(2, 4), new Point(1, 6), new Point(10, 9), new Point(0, 0) };

            List<Point> sortedPoints = Sort(points, comparer);

            foreach (Point p in sortedPoints)
            {
                Console.WriteLine(p);
            }
        }

        static List<Point> Sort(List<Point> points, PointComparer filter)
        {
            if (points == null) throw new ArgumentNullException("List is null here");
            if (filter == null) throw new ArgumentNullException("Filter is null here");

            List<Point> sortedPoints = new List<Point>(points);

            for (int i = 0; i < sortedPoints.Count - 1; i++)
            {
                for (int j = 0; j < sortedPoints.Count - i - 1; j++)
                {
                    if (filter(sortedPoints[j], sortedPoints[j + 1]))
                    {
                        Point temp = sortedPoints[j];
                        sortedPoints[j] = sortedPoints[j + 1];
                        sortedPoints[j + 1] = temp;
                    }
                }
            }

            return sortedPoints;
        }
    }
}
