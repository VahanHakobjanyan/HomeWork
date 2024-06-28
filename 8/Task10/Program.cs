namespace Task10
{
    internal class Program
    {
        //Task10: Pizza Toppings Enum
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what toppings you want too add to your pizza");
            Console.WriteLine("0 - None\n1 - Pepperoni\nMushroom - 2\nOnion - 3\n");

            int customerChoice = 0;
            int.TryParse(Console.ReadLine(), out customerChoice);

            while (customerChoice < 0 || customerChoice > 3)
            {
                Console.WriteLine("Enter number between 0 and 3");
                Console.WriteLine("0 - None\n1 - Pepperoni\nMushroom - 2\nOnion - 3\n");
                int.TryParse(Console.ReadLine(), out customerChoice);
            }

            PizzaToppings topping = PizzaToppings.None;

            switch (customerChoice)
            {
                case 0:
                    Console.WriteLine("Your pizza is ready");
                    return;
                case 1:
                    topping = PizzaToppings.Mushroom;
                    break;
                case 2:
                    topping = PizzaToppings.Mushroom;
                    break;
                case 3:
                    topping = PizzaToppings.Onion;
                    break;
            }

            Console.WriteLine("Your {0} pizza is ready", topping);

            Console.ReadKey();
        }
    }

    enum PizzaToppings
    {
        None = 0,
        Pepperoni,
        Mushroom,
        Onion
    }
}
