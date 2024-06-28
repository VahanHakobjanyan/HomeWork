namespace Task12
{
    internal class Program
    {
        //Task12: Clear Bit Using Bitwise AND with Negation
        static void Main(string[] args)
        {
            Permissions permissions = Permissions.Read | Permissions.Write | Permissions.Execute;

            Console.WriteLine(permissions);

            permissions = permissions & ~Permissions.Execute;

            Console.WriteLine(permissions);

            Console.ReadKey();
        }
    }
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
}
