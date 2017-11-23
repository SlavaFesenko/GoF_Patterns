namespace GoF_Patterns.Decorator.Example
{
    abstract class APizza
    {
        protected APizza(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
