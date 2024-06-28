namespace Task14
{
    internal class Program
    {
        //Task 14: Age Group Classification
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Enter age");
            int.TryParse(Console.ReadLine(), out age);

            if (age > 0 && age < 120)
            {
                if (age > 59)
                    Console.WriteLine("Senior");
                else if (age > 18)
                    Console.WriteLine("Adult");
                else if (age > 12)
                    Console.WriteLine("Teenager");
                else
                    Console.WriteLine("Child");
            }
            else
                Console.WriteLine("Try again. Enter valid number");

            Console.ReadKey();
        }
    }
}
