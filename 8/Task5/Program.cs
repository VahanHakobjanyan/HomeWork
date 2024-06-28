namespace Task5
{
    internal class Program
    {
        //Task5: Weekdays Enum:
        static void Main(string[] args)
        {
            Weekdays day = Weekdays.Tuesday;
            Console.WriteLine("Is {0} working day - {1}", day, isWorkingDay(day));

            day = Weekdays.Sunday;
            Console.WriteLine("Is {0} working day - {1}", day, isWorkingDay(day));

            Console.ReadKey();
        }
        static bool isWorkingDay(Weekdays day)
        {
            switch (day)
            {
                case Weekdays.Saturday:
                case Weekdays.Sunday:
                    return false;
                default:
                    return true;
            }
        }
    }

    enum Weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
