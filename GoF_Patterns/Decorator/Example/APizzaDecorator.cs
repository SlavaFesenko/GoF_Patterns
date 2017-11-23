namespace GoF_Patterns.Decorator.Example
{
    abstract class APizzaDecorator: APizza
    {
        protected APizza Pizza;

        protected APizzaDecorator(string name, APizza pizza): base(name)
        {
            Pizza = pizza;
        }
    }
}
