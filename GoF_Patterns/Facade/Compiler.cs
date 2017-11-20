using GoF_Patterns.Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade
{
    class Compiler : ICompiler
    {
        public void Compile()
        {
            Console.WriteLine("Compiler compile code...");
        }
    }
}
