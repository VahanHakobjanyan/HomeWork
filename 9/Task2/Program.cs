namespace Task2
{
    internal class Program
    {
        //Task2: //Reverse Order:
        static void Main(string[] args)
        {
            int[] ints = new int[3] { 2, 5, 7 };

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[ints.Length - 1 - i] + " ");
            }

            Console.ReadKey();
        }
    }
}
