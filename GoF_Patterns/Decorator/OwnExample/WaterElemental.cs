namespace GoF_Patterns.Decorator.OwnExample
{
    class WaterElemental : ASpellDecorator
    {
        public WaterElemental(ASpell spell) : base(spell.Name + " water", spell) { }

        public override double WaterPoints()
        {
            return Spell.WaterPoints() + 100;
        }

        public override double AirPoints()
        {
            return Spell.AirPoints();
        }

        public override double FirePoints()
        {
            return Spell.FirePoints();
        }

        public override double EarthPoints()
        {
            return Spell.EarthPoints();
        }
    }
}