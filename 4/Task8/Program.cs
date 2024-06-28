namespace Task8
{
    internal class Program
    {
        //Task 8: Checking for Null or Empty Strings
        static void Main(string[] args)
        {
            string emptyString = string.Empty;
            string whitespaceString = " ";

            Console.WriteLine($"Is empty string null or EMPTY - {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"Is whitespace string null or EMPTY - {string.IsNullOrEmpty(whitespaceString)}");

            Console.WriteLine($"Is empty string null or EMPTY or whitespace - {string.IsNullOrWhiteSpace(emptyString)}");
            Console.WriteLine($"Is whitespace string null or EMPTY or whitespace - {string.IsNullOrWhiteSpace(whitespaceString)}");

            Console.ReadKey();
        }
    }
}
