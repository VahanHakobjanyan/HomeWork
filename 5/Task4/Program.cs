namespace Task4
{
    internal class Program
    {
        //Task 4: if-else if-else Ladder
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Please enter score between 0 and 100.");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 90)
            {
                Console.WriteLine("A score");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B score");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C score");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D score");
            }
            else
            {
                Console.WriteLine("F score");
            }

            Console.ReadKey();
        }
    }
}
