namespace Task18
{
    internal class Program
    {
        //Task 18: Menu Selection Using Switch
        static void Main(string[] args)
        {
            byte option = 0;
            Console.WriteLine("Enter menu option");
            byte.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Option 1 selected");
                    break;
                case 2:
                    Console.WriteLine("Option 2 selected");
                    break;
                case 3:
                    Console.WriteLine("Option 3 selected");
                    break;
                case 4:
                    Console.WriteLine("Option 4 selected");
                    break;
                case 5:
                    Console.WriteLine("Option 5 selected");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.ReadKey();
        }
    }
}
