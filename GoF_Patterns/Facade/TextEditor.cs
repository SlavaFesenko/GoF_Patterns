using GoF_Patterns.Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade
{
    class TextEditor : ITextEditor
    {
        public void SaveCode()
        {
            Console.WriteLine("Saving code...");

        }

        public void WriteCode()
        {
            Console.WriteLine("Writing code...");
        }
    }
}
