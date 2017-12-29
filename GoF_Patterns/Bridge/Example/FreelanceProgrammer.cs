using System;

namespace GoF_Patterns.Bridge.Example
{
    class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Get money for completed job");
        }
    }
}