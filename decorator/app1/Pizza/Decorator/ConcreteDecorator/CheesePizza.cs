namespace Pizza.Decorator.ConcreteDecorator
{
    public class CheesePizza: Decorator
    {
        public CheesePizza(Interface.Pizza p)
            : base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}