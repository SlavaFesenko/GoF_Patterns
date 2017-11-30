using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Decorator.OwnExample
{
    abstract class ASpell
    {
        protected ASpell(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public virtual double FirePoints()
        {
            return 0;
        }

        public virtual double WaterPoints()
        {
            return 0;
        }
        public virtual double EarthPoints()
        {
            return 0;
        }
        public virtual double AirPoints()
        {
            return 0;
        }
    }

    abstract class ASpellDecorator : ASpell
    {
        protected ASpell Spell;
        protected ASpellDecorator(string name, ASpell spell) : base(name)
        {
            Spell = spell;
        }
    }

    class DamageSpell: ASpell
    {
        public DamageSpell(string name = "Damage spell ") : base(name) { }
    }

    class DefensiveSpell : ASpell
    {
        public DefensiveSpell(string name = "Defensive spell ") : base(name) { }
    }

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
