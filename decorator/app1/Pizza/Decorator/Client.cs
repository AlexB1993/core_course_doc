using System;

namespace Pizza.Decorator
{
    public class Client
    {
        public void ClientCode(Interface.Pizza pizza)
        {
            Console.WriteLine("Название: {0}", pizza.Name);
            Console.WriteLine("Цена: {0}", pizza.GetCost());
        }
    }
}