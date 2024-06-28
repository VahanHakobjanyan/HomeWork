namespace Task9
{
    internal class Program
    {
        //Task 9: Pattern Printing
        static void Main(string[] args)
        {
            int levelCount = 0;
            int.TryParse(Console.ReadLine(), out levelCount);

            string whitespaces = new string(' ', levelCount);
            int stars = 1;

            for (int i = 0; i < levelCount; i++)
            {
                Console.WriteLine(whitespaces + new string('*', stars));
                whitespaces = whitespaces.Substring(0, whitespaces.Length - 1);
                stars += 2;
            }

            Console.ReadKey();
        }
    }
}
