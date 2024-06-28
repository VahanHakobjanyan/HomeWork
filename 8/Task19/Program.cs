namespace Task19
{
    internal class Program
    {
        //Task19: Binary Representation of Enum Values:
        static void Main(string[] args)
        {
            Colors color = Colors.Black;
            string binary = Convert.ToString((int)color, 2);
            Console.WriteLine(binary);

            Console.ReadKey();
        }
    }

    enum Colors
    {
        Red = 0,
        Green = 1,
        Blue = 2,
        White = 4,
        Yellow = 8,
        Black = 16,
        Orange = 32,
        Gray = 64,
        Cyan = 128,
        Transparent = 256,
    }
}
