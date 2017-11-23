using System;

namespace GoF_Patterns.AbstractFactory.Example
{
    class FlyMovement : AMovement
    {
        public override void Move()
        {
            Console.WriteLine("Hero is flying...");
        }
    }
}