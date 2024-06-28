namespace Task6
{
    internal class Program
    {
        //Task 6: Replacing Substrings
        static void Main(string[] args)
        {
            string testString = "I love programming in Java";

            string finalString = testString.Replace("Java", "C#");

            Console.WriteLine(finalString);
            Console.ReadKey();
        }
    }
}
