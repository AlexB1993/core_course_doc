using System;
using app1.Decorator.Interface;

namespace app1.Decorator.Client
{
	public class Client
	{
		public void ClientCode(Component component)
		{
			Console.WriteLine("RESULT: " + component.Operation());
		}
	}
}