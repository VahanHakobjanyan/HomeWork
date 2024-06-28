namespace Task7
{
    internal class Program
    {
        //Task 7: Fibonacci Sequence
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int numberToCheck = 0;
            int.TryParse(Console.ReadLine(), out numberToCheck);

            if (numberToCheck == 0)
            {
                Console.WriteLine(0);
            }
            else if (numberToCheck == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int[] fibonacci = new int[numberToCheck + 1];

                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                foreach (int number in fibonacci)
                {
                    Console.Write(" " + number);
                }
            }

            Console.ReadKey();
        }
    }
}
