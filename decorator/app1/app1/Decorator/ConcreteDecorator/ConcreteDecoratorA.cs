using app1.Decorator.Interface;

namespace app1.Decorator.ConcreteDecorator
{
	public class ConcreteDecoratorA: Decorator
	{
		public ConcreteDecoratorA(Component comp) : base(comp)
		{
		}

		public override string Operation()
		{
			return $"ConcreteDecoratorA({base.Operation()})";
		}
	}
}