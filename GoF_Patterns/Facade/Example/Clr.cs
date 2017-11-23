using System;
using GoF_Patterns.Facade.Example.Interfaces;

namespace GoF_Patterns.Facade.Example
{
    class Clr : IClr
    {
        public void EndApp()
        {
            Console.WriteLine("CLR is ending application...");
        }

        public void StartApp()
        {
            Console.WriteLine("CLR is starting application...");

        }
    }
}
