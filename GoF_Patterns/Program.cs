using System;
using GoF_Patterns.Utils;

namespace GoF_Patterns
{
    class Program
    {
        static void Main()
        {
            PresenterFactory.GetPresenter(PatternType.Flyweight).PresentExample(); // test hotfix

            Console.ReadLine();
        }
    }
}
