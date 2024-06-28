namespace Task8
{
    internal class Program
    {
        //Task8: Frequency of Each Element
        static void Main(string[] args)
        {
            int[] ints = { 25, 12, 43 };

            for (int i = 0; i < ints.Length; i++)
            {
                int frequency = 0;

                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        frequency++;
                    }
                }

                Console.WriteLine("{0} occurs {1} times", ints[i], frequency);
            }

            Console.ReadKey();
        }
    }
}
