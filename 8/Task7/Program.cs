namespace Task7
{
    internal class Program
    {
        //Task7: User Role Enum
        static void Main(string[] args)
        {
            UserType user = UserType.User;
            UserType moderator = UserType.Moderator;
            UserType admin = UserType.Admin;

            Console.WriteLine("User");
            Login(user);
            ChangeContent(user);
            DeleteUser(user);

            Console.WriteLine("Moderator");
            Login(moderator);
            ChangeContent(moderator);
            DeleteUser(moderator);

            Console.WriteLine("Admin");
            Login(admin);
            ChangeContent(admin);
            DeleteUser(admin);

            Console.ReadKey();
        }
        static void Login(UserType user)
        {
            Console.WriteLine("You are logged in");
        }

        static void ChangeContent(UserType user)
        {
            //Only admin and moderator can manage content

            if (user.Equals(UserType.User))
            {
                Console.WriteLine("You need to be admin or moderator to change content. Current status {0}", user.ToString().ToUpper());
                return;
            }
            Console.WriteLine("Changes saved");
        }

        static void DeleteUser(UserType user)
        {
            //Only admin can manage users

            if (!user.Equals(UserType.Admin))
            {
                Console.WriteLine("You need to be admin to manage users. Current status {0}", user.ToString().ToUpper());
                return;
            }
            Console.WriteLine("User deleted. Saving changes");
        }
    }

    enum UserType
    {
        Admin,
        Moderator,
        User
    }
}
