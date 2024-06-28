namespace Task3
{
    internal class Program
    {
        //Task 3: Nested if Statements
        static void Main(string[] args)
        {
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            if (number > 0)
            {
                Console.Write("Number is bigger than 0. ");
                if (number < 50)
                {
                    Console.WriteLine("Number is smaller than 50");
                }
            }

            Console.ReadKey();
        }
    }
}
