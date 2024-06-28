namespace Get_Sum_and_Product_with_out
{
    internal class Program
    {
        //Task7: Get Sum and Product with out
        static void Main(string[] args)
        {
            int a = 20;
            int b = -13;
            int sum;

            GetSumAndProduct(a, b, out sum);

            Console.WriteLine(sum);
        }

        static void GetSumAndProduct(int a, int b, out int sum)
        {
            sum = a + b;
        }
    }
}
