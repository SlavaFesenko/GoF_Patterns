using System;

namespace GoF_Patterns.AbstractFactory.Example
{
    class Arbalet : AWeapon
    {
        public override void Hit()
        {
            Console.WriteLine("Striking from an arbalet...");
        }
    }
}