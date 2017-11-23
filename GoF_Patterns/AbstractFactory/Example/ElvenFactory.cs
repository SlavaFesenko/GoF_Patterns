using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.AbstractFactory.Example
{
    class ElvenFactory : AHeroFactory
    {
        public override AMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public override AWeapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
