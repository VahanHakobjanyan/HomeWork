namespace Task11
{
    internal class Program
    {
        //Task11: Set Bit Using Bitwise OR
        static void Main(string[] args)
        {
            WeekDays day = WeekDays.None;
            day |= WeekDays.Friday;

            Console.ReadKey();
        }
    }
    enum WeekDays
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
    }
}
