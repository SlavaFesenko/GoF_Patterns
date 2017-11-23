namespace GoF_Patterns.Decorator.Example
{
    class CheesePizza : APizzaDecorator
    {
        private const string Additive = " with cheese";
        public CheesePizza(APizza pizza) : base(pizza.Name + Additive, pizza) { }


        public override int GetCost()
        {
            return Pizza.GetCost() + 10;
        }
    }
}
