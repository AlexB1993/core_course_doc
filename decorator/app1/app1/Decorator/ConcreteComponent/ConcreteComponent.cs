using app1.Decorator.Interface;

namespace app1.Decorator.ConcreteComponent
{
	public class ConcreteComponent: Component
	{
		public override string Operation()
		{
			return "ConcreteComponent";
		}
	}
}