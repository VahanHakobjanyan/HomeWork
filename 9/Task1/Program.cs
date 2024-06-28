namespace Task1
{
    internal class Program
    {
        //Task1: Print Array Elements
        static void Main(string[] args)
        {
            int[] ints = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
