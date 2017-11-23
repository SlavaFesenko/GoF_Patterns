namespace GoF_Patterns.Decorator.Example
{
    class TomatoPizza: APizzaDecorator
    {
        private const string Additive = " with tomato";
        public TomatoPizza(APizza pizza): base(pizza.Name + Additive, pizza) { }


        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}
