using System;
using GoF_Patterns.Strategy.Example.Interfaces;

namespace GoF_Patterns.Strategy.Example.Realizations
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving on electricity...");
        }
    }
}
