namespace Task2
{
    internal class Program
    {
        //Task 2: Explicit Conversion (Casting)
        static void Main(string[] args)
        {
            double var1 = 125.326;
            int var2 = (int)var1;

            Console.WriteLine($"var1 = {var1}");
            Console.WriteLine($"var2 = {var2}");

            Console.ReadKey();
        }
    }
}
