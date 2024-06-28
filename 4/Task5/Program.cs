namespace Task5
{
    internal class Program
    {
        //Task 5: Splitting Strings
        static void Main(string[] args)
        {
            string professionNames = "engineer,astronaut,typewriter,programmer,driver,singer";
            string fruitNames = "apple, banana, orange, blueberry, strawberry, watermelon";

            string[] professions = professionNames.Split(",");
            string[] fruits = fruitNames.Split(", ");

            //using foreach
            Console.Write("Professions are `");
            foreach (string profession in professions)
            {
                Console.Write(profession + ", ");
            }

            Console.WriteLine();

            //using for
            Console.Write("Fruits are `");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write(fruits[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
