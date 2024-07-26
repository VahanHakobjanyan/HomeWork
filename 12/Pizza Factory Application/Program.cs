using Pizza_Factory_Application.Factories;
using Pizza_Factory_Application.OrderModel;

namespace Pizza_Factory_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassicPizzaFactory classic = new ClassicPizzaFactory();
            SpicyPizzaFactory spicy = new SpicyPizzaFactory();


            Client client = new Client("Vahan", "Hakobjanyan");

            OrderForm newOrder = client.Order(client.GetFullName(), FactoryNames.SpicyPizzaFactory, PizzaTypes.Hawaiian, 4);

            OrderOutput output = spicy.CheckOrder(newOrder);

            output.printOutput();

            Console.ReadKey();
        }
    }
}
