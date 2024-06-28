namespace Task11
{
    internal class Program
    {
        //Task 11: Combining if-else and switch
        static void Main(string[] args)
        {
            byte menuOption = 0;
            Console.WriteLine("Enter menu option");
            byte.TryParse(Console.ReadLine(), out menuOption);

            if (menuOption > 0 && menuOption < 4)
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Start game");
                        break;
                    case 2:
                        Console.WriteLine("Load game");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                }
            }
            else
                Console.WriteLine("Invalid option. Try again");

            Console.ReadKey();
        }
    }
}
