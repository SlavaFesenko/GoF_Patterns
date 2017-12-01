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
}
