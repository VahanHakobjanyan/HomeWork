using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.Factories
{
    internal class GourmetPizzaFactory : Factorie
    {
        public GourmetPizzaFactory()
        {
            Name = FactoryNames.GourmetPizzaFactory;
            Pizzas = PizzaTypes.Hawaiian | PizzaTypes.BBQChicken | PizzaTypes.Supreme;
        }
    }
}
