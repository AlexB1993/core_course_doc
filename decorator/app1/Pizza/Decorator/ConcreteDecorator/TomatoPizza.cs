namespace Pizza.Decorator.ConcreteDecorator
{
    public class TomatoPizza: Decorator
    {
        public TomatoPizza(Interface.Pizza p)
            : base(p.Name + ", с томатами", p)
        { }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}