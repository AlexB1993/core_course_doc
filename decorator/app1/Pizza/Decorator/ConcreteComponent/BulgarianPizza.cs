namespace Pizza.Decorator.ConcreteComponent
{
    public class BulgarianPizza: Interface.Pizza
    {
        public BulgarianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
}