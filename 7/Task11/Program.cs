namespace Task11
{
    internal class Program
    {
        //Task 11: Rock, Paper, Scissors Game
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock, paper, scissors");
            Console.WriteLine("Chose one of three options`");
            Console.WriteLine("1 for rock, 2 for paper and 3 for scissors");

            Random rnd = new Random();
            int pcChoice = rnd.Next(1, 3);

            int playerChoice = 0;
            bool isChoiceValid = false;
            string finalChoice = string.Empty;
            int winCount = 0, loseCount = 0, drawCount = 0, roundCount = 0;

            for (int i = 0; true; i++)
            {
                roundCount++;
                Console.WriteLine("{0}st round", roundCount);
                Console.WriteLine("your choice?");
                isChoiceValid = int.TryParse(Console.ReadLine(), out playerChoice);
                if (!isChoiceValid || playerChoice < 1 || playerChoice > 3)
                {
                    roundCount--;
                    Console.WriteLine("Enter valid choice");
                    continue;
                }

                switch (playerChoice)
                {
                    case 1:
                        Console.WriteLine("You chose rock");
                        switch (pcChoice)
                        {
                            case 1:
                                Console.WriteLine("Computer also chose rock!\n--DRAW--");
                                drawCount++;
                                break;
                            case 2:
                                Console.WriteLine("Computer chose paper!\n--YOU LOSE--");
                                loseCount++;
                                break;
                            case 3:
                                Console.WriteLine("Computer chose scissors!\n--YOU WIN--");
                                winCount++;
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("You chose paper");
                        switch (pcChoice)
                        {
                            case 1:
                                Console.WriteLine("Computer chose rock!\n--YOU WIN--");
                                winCount++;
                                break;
                            case 2:
                                Console.WriteLine("Computer also chose paper!\n--DRAW--");
                                drawCount++;
                                break;
                            case 3:
                                Console.WriteLine("Computer chose scissors!\n--YOU LOSE--");
                                loseCount++;
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("You chose scissors");
                        switch (pcChoice)
                        {
                            case 1:
                                Console.WriteLine("Computer chose rock!\n--YOU LOSE--");
                                loseCount++;
                                break;
                            case 2:
                                Console.WriteLine("Computer chose paper!\n--YOU WIN--");
                                winCount++;
                                break;
                            case 3:
                                Console.WriteLine("Computer also chose scissors!\n--DRAW--");
                                drawCount++;
                                break;
                        }
                        break;
                }

                Console.WriteLine("You want to continue. yes to continue. Anything other yes to exit");
                finalChoice = Console.ReadLine().ToLower();

                if (finalChoice.Equals("yes"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Won {winCount} times. Lost {loseCount} times. Draw {drawCount} times");
                    Console.WriteLine("Thank you for playing");
                    break;
                }
            }
        }
    }
}
