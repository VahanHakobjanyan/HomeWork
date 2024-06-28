namespace Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntSolution 

            int a = 30;
            int b = 15;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Change values in the code to see the difference");

            int sum = a + b;
            int dif = a - b;
            int mul = a * b;
            int div = a / b;

            Console.WriteLine("a + b = {0}", sum);
            Console.WriteLine("a - b = {0}", dif);
            Console.WriteLine("a * b = {0}", mul);
            Console.WriteLine("a / b = {0}", div);

            Console.ReadKey();
        }
    }
}
