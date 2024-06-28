namespace Task7
{
    internal class Program
    {
        //Task7: Merge Sorted Arrays
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2, 3 };

            Console.WriteLine("After merge");

            int[] mergedArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, mergedArray, array1.Length);
            Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
            PrintArray(mergedArray);

            Console.WriteLine("After sort");

            int[] sortedArray = SortArray(mergedArray);
            PrintArray(sortedArray);

            Console.ReadKey();
        }

        static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
