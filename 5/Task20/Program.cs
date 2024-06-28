namespace Task20
{
    internal class Program
    {
        //Task 20: Determine the Largest and Smallest of Five Numbers
        static void Main(string[] args)
        {
            int a = 123;
            int b = 5;
            int c = -423;
            int d = 0;
            int e = 1;

            int maxABC, maxDE = 0;

            if (a > b)
            {
                if (a > c)
                {
                    maxABC = a;
                }
                else
                {
                    maxABC = c;
                }
            }
            else
                maxABC = b;

            if (d > e)
            {
                maxDE = d;
            }
            else
            {
                maxDE = e;
            }

            if (maxABC > maxDE)
                Console.WriteLine($"Max is {maxABC}");
            else
                Console.WriteLine($"Max is {maxDE}");

            Console.ReadKey();
        }
    }
}
