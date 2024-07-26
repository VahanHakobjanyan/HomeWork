using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.Factories
{
    class SpicyPizzaFactory : Factorie
    {
        public SpicyPizzaFactory()
        {
            Name = FactoryNames.SpicyPizzaFactory;
            Pizzas = PizzaTypes.Mediterranean | PizzaTypes.BuffaloChicken | PizzaTypes.FourCheese;
        }
    }
}
