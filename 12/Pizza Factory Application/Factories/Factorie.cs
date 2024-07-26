using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza_Factory_Application.OrderModel;

namespace Pizza_Factory_Application.Factories
{
    abstract class Factorie
    {
        public FactoryNames Name { get; set; }
        public PizzaTypes Pizzas { get; set; }

        public OrderOutput CheckOrder(OrderForm order)
        {
            if (!order.Factorie.HasFlag(Name))
            {
                return new OrderOutput("Wrong factorie");
            }
            else
            {
                if (Pizzas.HasFlag(order.Pizza))
                {
                    return new OrderOutput("Order Placed\n", order.Count, order.Pizza);
                }
                else
                {
                    return new OrderOutput("Sorry. We dont make that type of pizza.");
                }
            }
        }
    }
}
