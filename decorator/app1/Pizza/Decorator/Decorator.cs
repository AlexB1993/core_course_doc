
namespace Pizza.Decorator
{
    public abstract class Decorator : Interface.Pizza
    {
        protected Interface.Pizza Pizza;
        protected Decorator(string n, Interface.Pizza pizza) : base(n)
        {
            Pizza = pizza;
        }
    }
}
