namespace GoF_Patterns.Decorator.Example
{
    class BulgerianPizza : APizza
    {
        private const string Type = "Bulgarian pizza";
        public BulgerianPizza(): base(Type)  { }
        public override int GetCost()
        {
            return 33;
        }
    }
}
