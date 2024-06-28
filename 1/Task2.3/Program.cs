namespace Task2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declaring variable without initialization");
            byte newByte;
            Console.WriteLine("byte newByte;");

            Console.WriteLine("Declaring variable with initialization");
            byte newByte2 = 55;
            Console.WriteLine("byte newByte2 = {0};", newByte2);

            Console.ReadKey();
        }
    }
}
