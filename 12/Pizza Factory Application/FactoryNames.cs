using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application
{
    [Flags]
    enum FactoryNames
    {
        ClassicPizzaFactory = 1,
        GourmetPizzaFactory = 2,
        SpicyPizzaFactory = 4,
        CustomPizzaFactory = 8,
    }
}
