using System;
using app1.Decorator.Client;
using app1.Decorator.ConcreteComponent;
using app1.Decorator.ConcreteDecorator;

namespace app1
{
	class Program
	{
		static void Main(string[] args)
		{
			Client client = new Client();

			var simple = new ConcreteComponent();
			Console.WriteLine("Простой клиент");
			client.ClientCode(simple);
			Console.WriteLine();

			ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
			ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
			Console.WriteLine("Клиент с обертками");
			client.ClientCode(decorator2);
			Console.ReadLine();
		}
	}

}
