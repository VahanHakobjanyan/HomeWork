using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pizza_Factory_Application.OrderModel;

namespace Pizza_Factory_Application
{
    class Client
    {
        public string Name
        {
            get;
        }
        public string Surname
        {
            get;
        }

        public string Email { get; }

        public Client(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Email = GetFullName() + "@gmail.com";
        }

        public OrderForm Order(string fullname, FactoryNames name, PizzaTypes pizza, int count)
        {
            return new OrderForm(fullname, name, pizza, count);
        }


        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
