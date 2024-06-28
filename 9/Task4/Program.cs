namespace Task4
{
    internal class Program
    {
        //Task4: Copy Elements to Another Array
        static void Main(string[] args)
        {
            int[] ints = { 15, 10, 12 };
            int[] newInts = new int[ints.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                newInts[i] = ints[i];
            }

            PrintIntArray(ints);
            PrintIntArray(newInts);

            Console.ReadKey();
        }

        static void PrintIntArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
