using System;

namespace GoF_Patterns.Bridge.Example
{
    class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Compile code into binary format by Roslin compiler");
        }

        public void Execute()
        {
            Console.WriteLine("CLR execute application");
        }
    }
}