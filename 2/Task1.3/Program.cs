namespace Task1._3
{
    internal class Program
    {
        //Task 1.3: Calculate Age
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year of your birth");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of your birth");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birthday");
            int days = int.Parse(Console.ReadLine());

            DateTime yearOfBirth = new DateTime(years, months, days);

            TimeSpan interval = DateTime.Now - yearOfBirth;

            byte age = (byte)(interval.TotalDays / 365);

            Console.WriteLine($"You are {age} years old.");

            Console.ReadKey();
        }
    }
}
