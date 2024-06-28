namespace Task20
{
    internal class Program
    {
        //Task20: Flags Enum with Multiple Selections
        static void Main(string[] args)
        {
            int customerChoice = 0;
            PizzaToppings topping = PizzaToppings.None;

            while (true)
            {
                Console.WriteLine("Enter number between 0 and 3");
                Console.WriteLine("0 - None\n1 - Pepperoni\nMushroom - 2\nOnion - 3\n");
                int.TryParse(Console.ReadLine(), out customerChoice);

                if (customerChoice < 0 || customerChoice > 3)
                {
                    Console.WriteLine("Enter correct option");
                    continue;
                }

                switch (customerChoice)
                {
                    case 0:
                        Console.WriteLine("Your pizza is ready");
                        return;
                    case 1:
                        topping |= PizzaToppings.Mushroom;
                        break;
                    case 2:
                        topping |= PizzaToppings.Mushroom;
                        break;
                    case 3:
                        topping |= PizzaToppings.Onion;
                        break;
                }

                Console.WriteLine("Do you want to add another topping to your pizza?\nyes/no");
                if (Console.ReadLine().ToLower().Equals("yes"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Your {0} pizza is ready", topping);

            Console.ReadKey();
        }
    }
    
    [Flags]
    enum PizzaToppings
    {
        None = 0,
        Pepperoni = 1,
        Mushroom = 2,
        Onion = 4,
        Olives = 8
    }
}
