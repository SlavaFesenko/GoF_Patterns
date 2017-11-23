using System;
using GoF_Patterns.Strategy.Example.Interfaces;

namespace GoF_Patterns.Strategy.Example.Realizations
{
    class PatrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving on patrol...");
        }
    }
}
