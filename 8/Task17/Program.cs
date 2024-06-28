namespace Task17
{
    internal class Program
    {
        //Task17: Custom Permissions Enum
        static void Main(string[] args)
        {
            Permissions permissions = Permissions.Read | Permissions.Write | Permissions.Delete;

            Console.WriteLine(checkReadAndWrite(permissions));

            Console.ReadKey();
        }

        static bool checkReadAndWrite(Permissions userPermissions)
        {
            if ((userPermissions & (Permissions.Read | Permissions.Write)) == (Permissions.Read | Permissions.Write))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    [Flags]
    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
}
