namespace Task4
{
    internal class Program
    {
        //Task 4: Searching Within Strings
        static void Main(string[] args)
        {
            string text = "Create a string variable with the value at some interesting text at blog(large interesting text).\r\n" +
                          "Check if the string contains the word (some word's) and print the result.\r\nFind the index of the words" +
                          " and print them.";

            Console.WriteLine("Enter the word to find occurances");
            string wordToCheck = Console.ReadLine();
            Console.WriteLine();

            string[] words = text.Split(" ");
            List<int> indexes = new List<int>();
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToCheck)
                {
                    count++;
                    indexes.Add(i);
                }
            }

            Console.WriteLine("Text`");
            Console.WriteLine(text + "\n");
            Console.WriteLine($"There are {count} {wordToCheck} words in the text. Indexes are `");
            foreach (int index in indexes)
            {
                Console.Write($"{index + 1}th, ");
            }

            Console.ReadKey();
        }
    }
}
