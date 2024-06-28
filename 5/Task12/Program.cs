namespace Task12
{
    internal class Program
    {
        //Task 12: Determine if a Number is Positive, Negative, or Zero
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter any integer number");
            int.TryParse(Console.ReadLine(), out number);

            if (number > 0)
                Console.WriteLine("Positive number");
            else if (number < 0)
                Console.WriteLine("Negative number");
            else
                Console.WriteLine("Number is zero");

            Console.ReadKey();
        }
    }
}
