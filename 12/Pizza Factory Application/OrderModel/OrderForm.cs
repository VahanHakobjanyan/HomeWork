using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.OrderModel
{
    class OrderForm
    {
        public string FullName { get; }
        public FactoryNames Factorie { get; }
        public PizzaTypes Pizza { get; }
        public int Count { get; }

        public OrderForm(string fullName, FactoryNames factorie, PizzaTypes pizza, int count)
        {
            FullName = fullName;
            Factorie = factorie;
            Pizza = pizza;
            Count = count;
        }
    }
}
