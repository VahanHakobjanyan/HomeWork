namespace Task19
{
    internal class Program
    {
        //Task 19: Check If a Character is a Vowel or Consonant
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter character");
            char.TryParse(Console.ReadLine(), out character);

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Character is a vowel");
                    break;
                default:
                    Console.WriteLine("Charactewr is not a vowel");
                    break;
            }

            Console.ReadKey();
        }
    }
}
