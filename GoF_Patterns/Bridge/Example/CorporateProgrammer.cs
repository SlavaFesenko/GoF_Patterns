using System;

namespace GoF_Patterns.Bridge.Example
{
    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Receive salary at the end of month");
        }

       
    }
}