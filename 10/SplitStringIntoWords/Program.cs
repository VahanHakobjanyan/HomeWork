namespace SplitStringIntoWords
{
    internal class Program
    {
        //Task13: Write a function called SplitStringIntoWords that takes a sentence as input and returns an array of individual words.
        static void Main(string[] args)
        {
            string sentence = "rfdwesf wfesrfwes hrtyh huioweqq hfre ghfjkdsf kweqrwerqa ewrkuyesy er";

            string[] sentenceDivided = SplitStringIntoWords(sentence);
            foreach (string word in sentenceDivided)
            {
                Console.WriteLine(word);
            }
        }

        static string[] SplitStringIntoWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words;
        }
    }
}
