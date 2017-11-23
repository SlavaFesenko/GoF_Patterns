using System;
using GoF_Patterns.Facade.Example.Interfaces;

namespace GoF_Patterns.Facade.Example
{
    class Compiler : ICompiler
    {
        public void Compile()
        {
            Console.WriteLine("Compiler compile code...");
        }
    }
}
