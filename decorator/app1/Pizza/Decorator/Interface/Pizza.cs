namespace Pizza.Decorator.Interface
{
    public abstract class Pizza
    {
        protected Pizza(string n)
        {
            Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}