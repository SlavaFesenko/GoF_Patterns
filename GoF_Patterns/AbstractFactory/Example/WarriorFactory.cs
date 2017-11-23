using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.AbstractFactory.Example
{
    class WarriorFactory: AHeroFactory
    {
        public override AMovement CreateMovement()
        {
            return new RunMovement();
        }

        public override AWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
