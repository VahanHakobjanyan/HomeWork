namespace Task3
{
    internal class Program
    {
        //Task 3: Using Convert Class
        static void Main(string[] args)
        {
            string numString = "856";

            int numInt = Convert.ToInt32(numString);

            Console.WriteLine($"string value is {numString}");
            Console.WriteLine($"int value is {numInt}");

            Console.ReadKey();
        }
    }
}
