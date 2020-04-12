
namespace Pizza.Decorator.ConcreteComponent
{
    public class ItalianPizza : Interface.Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }

        public override int GetCost()
        {
            return 10;
        }

    }
}