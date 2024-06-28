namespace Task16
{
    internal class Program
    {
        //Task16: Weekend Days Combination
        static void Main(string[] args)
        {
            Weekdays day = Weekdays.SaturdayAndSunday;

            bool isContained = (day & Weekdays.Sunday) == Weekdays.Sunday;

            Console.WriteLine(isContained);

            Console.ReadKey();
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
        Sunday,
        SaturdayAndSunday = Weekdays.Saturday | Weekdays.Sunday,
    }
}
