using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.Factories
{
    class CustomPizzaFactory : Factorie
    {
        public CustomPizzaFactory()
        {
            Name = FactoryNames.CustomPizzaFactory;
            Pizzas = PizzaTypes.PestoDelight | PizzaTypes.MeatLovers | PizzaTypes.SpinachandFeta | PizzaTypes.MushroomMadness;
        }
    }
}
