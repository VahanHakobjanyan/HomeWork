namespace Immutable_Line_Segment
{
    internal class Program
    {
        //Immutable Line Segment: Design an immutable LineSegment struct with start and end points.
        //Ensure no modifications after instantiation.

        static void Main(string[] args)
        {
            LineSegment segment1 = new LineSegment(13, 20);
            Console.WriteLine($"Start point - {segment1.StartPoint}, End point - {segment1.EndPoint}");

            LineSegment segment2 = new LineSegment(99, 19);
            Console.WriteLine($"Start point - {segment2.StartPoint}, End point - {segment2.EndPoint}");

            Console.ReadKey();
        }
    }

    struct LineSegment
    {
        public int StartPoint { get; }
        public int EndPoint { get; }

        public LineSegment(int startPoint, int endPoint)
        {
            if (IsValid())
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            } else
            {
                StartPoint = endPoint;
                EndPoint = startPoint;
            }
        }

        private bool IsValid()
        {
            return StartPoint < EndPoint;
        }
    }
}
