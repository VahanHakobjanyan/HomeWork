namespace Task3
{
    internal class Program
    {
        //Task3: Sum of Array Elements:
        static void Main(string[] args)
        {
            int[] ints = { 2, 5, 8 };
            int sum = 0;

            foreach (int i in ints)
            {
                sum += i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
