namespace Swap_Characters_with_ref
{
    internal class Program
    {
        //Task2: Swap Characters with ref
        static void Main(string[] args)
        {
            char a = '%'; 
            char b = '?';
            Console.WriteLine("Before method call");
            Console.WriteLine($"A = {a}, B = {b}");

            SwapCharactersWithRef(ref a, ref b);

            Console.WriteLine("After method call");
            Console.WriteLine($"A = {a}, B = {b}");
        }

        static void SwapCharactersWithRef(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
