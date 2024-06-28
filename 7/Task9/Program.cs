namespace Task9
{
    internal class Program
    {
        //Task 9: Count Words in a Sentence
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string word = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.IndexOf(word) != -1)
                {
                    counter++;
                }
                i = sentence.IndexOf(word) + word.Length - 1;
            }

            Console.WriteLine("{0} occuarancies of word {word} in the sentence");

            Console.ReadKey();
        }
    }
}
