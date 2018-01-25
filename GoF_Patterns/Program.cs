using System;
using GoF_Patterns.Utils;

namespace GoF_Patterns
{
    class Program
    {
        static void Main()
        {
            PresenterFactory.GetPresenter(PatternType.Bridge).PresentExample();

            Console.ReadLine();
        }
    }
}
