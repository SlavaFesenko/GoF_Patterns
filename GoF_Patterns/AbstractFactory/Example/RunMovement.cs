using System;

namespace GoF_Patterns.AbstractFactory.Example
{
    class RunMovement : AMovement
    {
        public override void Move()
        {
            Console.WriteLine("Hero is running...");
        }
    }
}