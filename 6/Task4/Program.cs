namespace Task4
{
    internal class Program
    {
        //Task 4: Reverse a String
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }

            Console.ReadKey();
        }
    }
}
