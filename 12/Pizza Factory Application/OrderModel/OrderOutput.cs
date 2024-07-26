using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory_Application.OrderModel
{
    internal class OrderOutput
    {
        public string Message { get; }

        public OrderOutput(string message)
        {
            Message = message;
        }

        public OrderOutput(string message, int count, PizzaTypes type)
        {
            Message = message;
        }
        public void printOutput()
        {
            Console.WriteLine(Message);
        }
    }
}
