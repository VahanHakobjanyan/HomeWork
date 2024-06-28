namespace Task8
{
    internal class Program
    {
        //Task 8: if with Logical Operators
        static void Main(string[] args)
        {
            int temperature = 0;
            Console.WriteLine("Enter temperature");
            int.TryParse(Console.ReadLine(), out temperature);

            bool isRaining = false;
            Console.WriteLine("Is it raining now?(True or False)");
            bool.TryParse(Console.ReadLine(), out isRaining);

            if (temperature > 20 && !isRaining)
            {
                Console.WriteLine("Good weather for a walk");
            }
            else
            {
                Console.WriteLine("stay indoors");
            }

            Console.ReadKey();
        }
    }
}
