using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.AbstractFactory.Example
{
    abstract class AHeroFactory
    {
        public abstract AMovement CreateMovement();
        public abstract AWeapon CreateWeapon();
    }
}
