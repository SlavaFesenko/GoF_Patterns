using System;

namespace GoF_Patterns.AbstractFactory.Example
{
    class Sword : AWeapon
    {
        public override void Hit()
        {
            Console.WriteLine("Hitting by sword...");
        }
    }
}