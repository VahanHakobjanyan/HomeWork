namespace Task4
{
    internal class Program
    {
        //Task 4: Using int.Parse and int.TryParse
        static void Main(string[] args)
        {
            string numValue = "73";
            int num = int.Parse(numValue);

            Console.WriteLine($"conversion from string to int is successfull: num = {num}");

            string nonNumValue = "%Hello#332";

            bool result = int.TryParse(nonNumValue, out num);

            if (result == true)
            {
                Console.WriteLine($"Conversion from non numeric string is successfull: num = {num}");
            }
            else
            {
                Console.WriteLine($"Cannot convert non numeric string to int");
            }

            Console.ReadKey();
        }
    }
}
