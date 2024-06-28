namespace Task6
{
    internal class Program
    {
        //Task 6: switch Statement with Strings
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "start":
                    {
                        Console.WriteLine("Starting video playback");
                        break;
                    }
                case "stop":
                    {
                        Console.WriteLine("Stoping video playback");
                        break;
                    }
                case "pause":
                    {
                        Console.WriteLine("Pausing video playback");
                        break;
                    }
                case "resume":
                    {
                        Console.WriteLine("Resuming video playback");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try again. Enter correct command");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
