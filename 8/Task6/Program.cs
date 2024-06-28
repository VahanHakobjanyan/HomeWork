namespace Task6
{
    internal class Program
    {
        //Task6: Seasons Enum:
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month`");
            byte month = byte.Parse(Console.ReadLine());

            Seasons season;

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month. Enter again");
                month = byte.Parse(Console.ReadLine());
            }

            if (month < 4)
            {
                season = Seasons.Spring;
            }
            else if (month < 7)
            {
                season = Seasons.Summer;
            }
            else if (month < 10)
            {
                season = Seasons.Autumn;
            }
            else
            {
                season = Seasons.Winter;
            }

            Console.WriteLine(season);
            Console.ReadKey();
        }
    }

    enum Seasons
    {
        None = 0,
        Spring,
        Summer,
        Autumn,
        Winter
    }
}
