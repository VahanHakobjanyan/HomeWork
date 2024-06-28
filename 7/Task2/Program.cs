namespace Task2
{
    internal class Program
    {
        //Task 2: Count Occurrences of a Character
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string!");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter character to check!");
            char key = ' ';
            char.TryParse(Console.ReadLine(), out key);

            int counter = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == key)
                {
                    counter++;
                }
            }

            Console.WriteLine("Found {0} {1}s in the string", counter, key);

            Console.ReadKey();
        }
    }
}
