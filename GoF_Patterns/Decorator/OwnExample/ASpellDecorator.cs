namespace GoF_Patterns.Decorator.OwnExample
{
    abstract class ASpellDecorator : ASpell
    {
        protected ASpell Spell;
        protected ASpellDecorator(string name, ASpell spell) : base(name)
        {
            Spell = spell;
        }
    }
}