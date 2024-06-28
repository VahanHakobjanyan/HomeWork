namespace Reverse_String_with
{
    internal class Program
    {
        //Task4: Reverse String with
        static void Main(string[] args)
        {
            string str = "NameSurname";
            Console.WriteLine(str);

            ReverseString(ref str);

            Console.WriteLine(str);
        }

        static void ReverseString(ref string s)
        {
            s = new String(s.ToCharArray().Reverse().ToArray());
        }
    }
}
