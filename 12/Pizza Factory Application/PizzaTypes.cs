using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application
{
    [Flags]
    enum PizzaTypes
    {
        Margherita = 0,
        Pepperoni = 2,
        Veggie = 4,
        Hawaiian = 8,
        BBQChicken = 16, 
        Supreme = 32, 
        Mediterranean = 64, 
        BuffaloChicken = 128, 
        FourCheese = 256,
        PestoDelight = 512, 
        MeatLovers = 1024,
        SpinachandFeta = 2048,
        MushroomMadness = 4096,
    }
}
