namespace Task1
{
    internal class Program
    {
        //Task 1: Implicit Conversion
        static void Main(string[] args)
        {
            int var1 = 25;

            double var2 = var1;

            Console.WriteLine($"var2 = {var2}");
            Console.WriteLine($"var1 = {var1}");

            Console.ReadKey();
        }
    }
}
