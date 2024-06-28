namespace Task10
{
    internal class Program
    {
        //Task 10: Number Guessing Game
        static void Main(string[] args)
        {
            Random num = new Random();
            int numberToGuess = num.Next(1, 100);

            int userNumber = 0;
            Console.WriteLine("Enter number between 1 and 100");
            int counter = 0;

            for (int i = 0; true; i++)
            {
                counter++;
                if (counter > 1)
                {
                    Console.WriteLine("Enter number again");
                }

                int.TryParse(Console.ReadLine(), out userNumber);
                if (userNumber == numberToGuess)
                {
                    Console.WriteLine("Congratulations. You guessed number {0} from {1} tries", numberToGuess, counter);
                    break;
                }
                else
                {
                    if (userNumber > numberToGuess + 20)
                    {
                        Console.WriteLine("Too high. Try again");
                        continue;
                    }
                    else if (userNumber > numberToGuess + 10)
                    {
                        Console.WriteLine("A bit high. Try again");
                        continue;
                    }
                    else if (userNumber > numberToGuess)
                    {
                        Console.WriteLine("Almost there. Just a little bit high");
                        continue;
                    }
                    else if (userNumber < numberToGuess - 20)
                    {
                        Console.WriteLine("Too low. Try again");
                        continue;
                    }
                    else if (userNumber < numberToGuess - 10)
                    {
                        Console.WriteLine("A bit low. Try again");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Almost there. Just a little bit low");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
