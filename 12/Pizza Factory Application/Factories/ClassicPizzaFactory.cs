using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.Factories
{
    class ClassicPizzaFactory : Factorie
    {
        public ClassicPizzaFactory()
        {
            Name = FactoryNames.ClassicPizzaFactory;
            Pizzas = PizzaTypes.Margherita | PizzaTypes.Pepperoni | PizzaTypes.Veggie;
        }
    }
}
