namespace N_prime_numbers
{
    internal class Program
    {
        //task10: N prime numbers
        static void Main(string[] args)
        {
            NPrimeNumbers(15);
        }

        static void NPrimeNumbers(int n)
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);


            if (n <= 4)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(primeNumbers[i] + " ");
                }
                return;
            }
            if (n > 4)
            {
                for (int i = 11; true; i++)
                {
                    if (primeNumbers.Count <= n)
                    {
                        if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            primeNumbers.Add(i);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(primeNumbers[i] + " ");
                }
            }
        }
    }
}