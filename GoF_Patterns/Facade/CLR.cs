using GoF_Patterns.Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade
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
