namespace GoF_Patterns.Decorator.OwnExample
{
    class EarthElemental : ASpellDecorator
    {
        public EarthElemental(ASpell spell) : base(spell.Name + " earth", spell) { }

        public override double EarthPoints()
        {
            return Spell.EarthPoints() + 100;
        }

        public override double AirPoints()
        {
            return Spell.AirPoints();
        }

        public override double FirePoints()
        {
            return Spell.FirePoints();
        }

        public override double WaterPoints()
        {
            return Spell.WaterPoints();
        }
    }
}