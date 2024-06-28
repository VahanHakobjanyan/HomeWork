namespace Task6
{
    internal class Program
    {
        //Task6: Print Unique Elements
        static void Main(string[] args)
        {
            int[] ints = { 1, 5, 1 };

            for (int i = 0; i < ints.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < ints.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (ints[i] == ints[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.Write(ints[i] + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
