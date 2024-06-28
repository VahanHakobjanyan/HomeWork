namespace Task15
{
    internal class Program
    {
        //Task 15: Determine the Largest of Four Numbers
        static void Main(string[] args)
        {
            decimal maxAB = 0;
            decimal maxCD = 0;

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

            if (a > b)
                maxAB = a;
            else
                maxAB = b;

            if (c > d)
                maxCD = c;
            else
                maxCD = d;

            if (maxAB > maxCD)
                Console.WriteLine($"Max number is {maxAB}");
            else
                Console.WriteLine($"Max number is {maxCD}");

            Console.ReadKey();
        }
    }
}
