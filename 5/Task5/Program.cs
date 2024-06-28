namespace Task5
{
    internal class Program
    {
        //Task 5: switch Statement with Integers
        static void Main(string[] args)
        {
            byte dayOfWeek = 3;

            switch (dayOfWeek)
            {
                case 1:
                    {
                        Console.WriteLine("Its monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Its tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Its wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Its thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Its friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Its saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Its sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try again. Enter valid number from 1 to 7");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
