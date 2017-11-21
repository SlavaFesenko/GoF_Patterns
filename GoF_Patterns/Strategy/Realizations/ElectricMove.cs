using GoF_Patterns.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Strategy.Realizations
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Moving on electricity...");
        }
    }
}
