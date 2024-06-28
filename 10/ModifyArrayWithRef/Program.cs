namespace ModifyArrayWithRef
{
    internal class Program
    {
        //Task3: ModifyArrayWithRef
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomizer.Next(1, 10);
            }

            Console.WriteLine("Before method call");
            PrintArray(numbers);

            ModifyArrayWithRef(ref numbers);

            Console.WriteLine("After method call with ref");
            PrintArray(numbers);

        }

        static void ModifyArrayWithRef(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
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
