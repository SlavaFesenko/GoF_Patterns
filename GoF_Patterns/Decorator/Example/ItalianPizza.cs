namespace GoF_Patterns.Decorator.Example
{
    class ItalianPizza : APizza
    {
        private const string Type = "Italian pizza";
        public ItalianPizza():base(Type) { }

        public override int GetCost()
        {
            return 22;
        }
    }
}
