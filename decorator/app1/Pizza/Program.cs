using System;
using Pizza.Decorator;
using Pizza.Decorator.ConcreteComponent;
using Pizza.Decorator.ConcreteDecorator;
using PizzaInterface = Pizza.Decorator.Interface.Pizza;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
           Client client =  new Client();
           PizzaInterface pizzaIt = new ItalianPizza();
           client.ClientCode(pizzaIt);

           //добавим сыр 

           PizzaInterface italianWithCheese = new CheesePizza(pizzaIt);
           client.ClientCode(italianWithCheese);


           PizzaInterface pizzaBulgarian = new BulgarianPizza();
           client.ClientCode(pizzaBulgarian);

            // c сыром и томатами
            PizzaInterface bulgarianWithCheese = new CheesePizza(pizzaBulgarian);
            PizzaInterface bulgarianWithTomato = new TomatoPizza(bulgarianWithCheese);
            client.ClientCode(bulgarianWithTomato);
            Console.ReadLine();


        }
    }
}
