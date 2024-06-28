namespace Task5
{
    internal class Program
    {
        //Task 5: Count Vowels in a String
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any word");
            string userInput = Console.ReadLine();
            int vowelCount = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("{0} vowels in the word {1}", vowelCount, userInput);
            Console.ReadKey();
        }
    }
}
