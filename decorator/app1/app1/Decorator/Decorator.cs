using app1.Decorator.Interface;

namespace app1.Decorator
{
	public abstract class Decorator: Component
	{
		protected Component _component;

		public Decorator(Component component)
		{
			this._component = component;
		}

		public void SetComponent(Component component)
		{
			this._component = component;
		}

		// Декоратор делегирует всю работу обёрнутому компоненту.
		public override string Operation()
		{
			if (_component != null)
			{
				return _component.Operation();
			}
			return string.Empty;
			
		}
	}
}