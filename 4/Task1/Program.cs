namespace Task1
{
    internal class Program
    {
        //Task 1: Basic String Operations
        static void Main(string[] args)
        {
            string str = "Hello world_____fsdfsd";

            Console.WriteLine($"Length is {str.Length}");
            Console.WriteLine($"Uppercase string is {str.ToUpper()}");
            Console.WriteLine($"Lowercase string is {str.ToLower()}");
            Console.WriteLine($"Extracted substring equals {str.Substring(str.IndexOf('w'), "world".Length)}");

            Console.ReadKey();
        }
    }
}
