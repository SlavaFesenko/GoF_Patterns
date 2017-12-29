using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Bridge.Example
{
    class CppLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Compile programm by C++ compiler");
        }

        public void Execute()
        {
            Console.WriteLine("Run programm's execution file");
        }
    }
}
