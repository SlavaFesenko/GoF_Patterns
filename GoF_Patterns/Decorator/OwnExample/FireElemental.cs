namespace GoF_Patterns.Decorator.OwnExample
{
    class FireElemental : ASpellDecorator
    {
        public FireElemental(ASpell spell) : base(spell.Name + " fire", spell) { }

        public override double FirePoints()
        {
            return Spell.FirePoints() + 100;
        }
        public override double AirPoints()
        {
            return Spell.AirPoints();
        }

        public override double WaterPoints()
        {
            return Spell.WaterPoints();
        }

        public override double EarthPoints()
        {
            return Spell.EarthPoints();
        }
    }
}