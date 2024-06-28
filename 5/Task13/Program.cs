namespace Task13
{
    internal class Program
    {
        //Task 13: Grade Categorization
        static void Main(string[] args)
        {
            int grade = 0;
            Console.WriteLine("Enter grade between 1 and 10");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade < 1 || grade > 10)
            {
                Console.WriteLine("Try again. Enter valid number");
                return;
            }

            if (grade > 8)
                Console.WriteLine("Exellent");
            else if (grade > 6)
                Console.WriteLine("Good");
            else if (grade > 4)
                Console.WriteLine("Average");
            else if (grade > 2)
                Console.WriteLine("Poor");
            else
                Console.WriteLine("Fail");

            Console.ReadKey();
        }
    }
}
