namespace Task14
{
    internal class Program
    {
        //Task14: Check If a Flag Is Set
        static void Main(string[] args)
        {
            FontStyles style1 = FontStyles.Bold | FontStyles.Italic;

            bool isItalicAssigned = (style1 & FontStyles.Italic) == FontStyles.Italic;
            Console.WriteLine(isItalicAssigned);

            Console.ReadKey();
        }
    }

    [Flags]
    enum FontStyles
    {
        Bold = 1,
        Italic = 2,
        UnderLine = 4
    }
}
