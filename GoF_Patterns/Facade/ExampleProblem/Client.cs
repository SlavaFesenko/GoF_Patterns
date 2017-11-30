using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Facade.Example;

namespace GoF_Patterns.Facade.ExampleProblem
{
    static class EpClient
    {
        public static void UsePattern(Clr clr, TextEditor te, Compiler cp)
        {
            te.WriteCode();
            te.SaveCode();

            cp.Compile();

            clr.StartApp();
            clr.EndApp();
        }
    }

   
}
