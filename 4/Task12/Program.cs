namespace Task12
{
    internal class Program
    {
        //Task 12: Equals
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));

            Console.ReadKey();
        }
    }
}
