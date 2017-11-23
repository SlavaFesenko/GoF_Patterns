using System;
using GoF_Patterns.Facade.Example.Interfaces;

namespace GoF_Patterns.Facade.Example
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
