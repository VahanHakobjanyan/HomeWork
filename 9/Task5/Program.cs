namespace Task5
{
    internal class Program
    {

        //Task5: Count Duplicate Elements
        static void Main(string[] args)
        {
            int[] ints = { 5, 1, 1 };
            int duplicateCounter = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < ints.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (ints[i] == ints[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    duplicateCounter++;
                }
            }
            Console.WriteLine(duplicateCounter);
            
            Console.ReadKey();
        }
    }
}
