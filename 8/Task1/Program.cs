namespace Task1
{
    internal class Program
    {
        //Task1: Declare and Assign Enum Constants:
        static void Main(string[] args)
        {
            Weather weather = Weather.Sunny;
            Console.WriteLine(weather);

            weather = Weather.Cloudy;
            Console.WriteLine(weather);

            weather = Weather.Rainy;
            Console.WriteLine(weather);

            Console.ReadKey();
        }
    }

    enum Weather
    {
        Sunny,
        Rainy,
        Cloudy
    }
}
