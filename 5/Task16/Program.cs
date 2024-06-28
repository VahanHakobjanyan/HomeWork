namespace Task16
{
    internal class Program
    {
        //Task 16: Determine the Smallest of Four Numbers
        static void Main(string[] args)
        {
            decimal minAB = 0;
            decimal minCD = 0;

            decimal a = 0;
            Console.WriteLine("Enter first number");
            decimal.TryParse(Console.ReadLine(), out a);

            decimal b = 0;
            Console.WriteLine("Enter second number");
            decimal.TryParse(Console.ReadLine(), out b);

            decimal c = 0;
            Console.WriteLine("Enter third number");
            decimal.TryParse(Console.ReadLine(), out c);

            decimal d = 0;
            Console.WriteLine("Enter fourth number");
            decimal.TryParse(Console.ReadLine(), out d);

            if (a < b)
                minAB = a;
            else
                minAB = b;

            if (c < d)
                minCD = c;
            else
                minCD = d;

            if (minAB < minCD)
                Console.WriteLine($"Min number is {minAB}");
            else
                Console.WriteLine($"Min number is {minCD}");

            Console.ReadKey();
        }
    }
}
