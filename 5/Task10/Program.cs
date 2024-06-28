namespace Task10
{
    internal class Program
    {
        //Task 10: Nested if with Multiple Conditions
        static void Main(string[] args)
        {
            int a = 110;
            int b = 26;
            int c = 132;

            int max = 0;

            if (a > b)
            {
                max = a;

                if (a < c)
                {
                    max = c;
                }
            }
            else
            {
                max = b;

                if (b < c)
                {
                    max = c;
                }
            }

            Console.WriteLine($"A = {a}\nB = {b}\nC = {c}/nMax = {max}");

            Console.ReadKey();
        }
    }
}
