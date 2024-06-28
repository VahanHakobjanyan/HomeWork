namespace Task9
{
    internal class Program
    {
        //Task 9: switch with Fall-through
        static void Main(string[] args)
        {
            byte level = 0;
            Console.WriteLine("Enter level");
            byte.TryParse(Console.ReadLine(), out level);

            switch (level)
            {
                case 1:
                    Console.WriteLine("Begginer");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Invalid level");
                    break;
            }

            Console.ReadKey();
        }
    }
}
