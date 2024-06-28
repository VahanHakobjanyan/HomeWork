namespace Task8
{
    internal class Program
    {
        //Task8: Traffic Light Enum:
        static void Main(string[] args)
        {
            ShowTrafficLight(TrafficLights.Red, 5000);
            ShowTrafficLight(TrafficLights.Yellow, 1500);
            ShowTrafficLight(TrafficLights.Green, 3000);

            Console.ReadKey();
        }

        static void ShowTrafficLight(TrafficLights color, int delay)
        {
            switch (color)
            {
                case TrafficLights.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case TrafficLights.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case TrafficLights.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
            }
            Console.Clear();
            Thread.Sleep(delay);
        }
    }
    enum TrafficLights
    {
        Red,
        Yellow,
        Green,
    }
}
