namespace GoF_Patterns.Decorator.OwnExample
{
    class AirElemental : ASpellDecorator
    {
        public AirElemental(ASpell spell) : base(spell.Name + " air", spell) { }

        public override double AirPoints()
        {
            return Spell.AirPoints() + 100;
        }

        public override double FirePoints()
        {
            return Spell.FirePoints();
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