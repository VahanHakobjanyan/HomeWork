namespace Task10
{
    internal class Program
    {
        //Task 10: GetHashCode
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = str1;
            string str3 = "world";

            if (str1.GetHashCode() == str2.GetHashCode())
            {
                Console.WriteLine("Str1 and Str2 hashcodes are same.");
            }

            Console.WriteLine("First string hash code - {0}", str1.GetHashCode());
            Console.WriteLine("Second string hash code - {0}", str2.GetHashCode());
            Console.WriteLine("Third string hash code - {0}", str3.GetHashCode());

            Console.ReadKey();
        }
    }
}
