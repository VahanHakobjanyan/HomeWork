namespace Task9
{
    internal class Program
    {
        //Task 9: String Comparison
        static void Main(string[] args)
        {
            string lowerGreeting = "hello";
            string UpperGreeting = "HELLO";

            bool result = lowerGreeting.Equals(UpperGreeting);
            Console.WriteLine("Using String.Equals - {0}", result);

            //Ignoring the case
            result = lowerGreeting.Equals(UpperGreeting, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
