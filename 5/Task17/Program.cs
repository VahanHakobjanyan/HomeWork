namespace Task17
{
    internal class Program
    {
        //Task 17: Determine the Type of Triangle
        static void Main(string[] args)
        {
            int firstSide = 15;
            int secondSide = 30;
            int thirdSide = 15;

            if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
            {
                if (firstSide == secondSide && firstSide == thirdSide)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else
                {
                    Console.WriteLine("Isoceles triangle");
                }
            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }

            Console.ReadKey();
        }
    }
}
