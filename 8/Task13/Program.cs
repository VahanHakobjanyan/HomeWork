namespace Task13
{
    internal class Program
    {
        //Task13: Combine Multiple Flags
        static void Main(string[] args)
        {
            UserRoles user = UserRoles.user;
            UserRoles admin = UserRoles.Admin | UserRoles.Moderator | UserRoles.user;

            Console.WriteLine(user);
            Console.WriteLine(admin);

            Console.ReadKey();
        }
    }

    [Flags]
    enum UserRoles
    {
        user = 1,
        Admin = 2,
        Moderator = 4
    }
}
