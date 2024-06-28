namespace Task1._4
{
    internal class Program
    {
        //Task 1.4: Calculate Year of Birth
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age by format dd/MM/yyyy");
            Console.WriteLine("Days?");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Months");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Years?");
            int years = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = DateTime.Now.AddYears(-years).AddMonths(-months).AddDays(-days);

            Console.WriteLine("\nYour birthday is `");
            Console.WriteLine(dateOfBirth.ToString("dd.MM.yyyy"));

            Console.ReadKey();
        }
    }
}
