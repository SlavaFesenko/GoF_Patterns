using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Facade;
using GoF_Patterns.Strategy;

namespace GoF_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FacadePresenter.PresentPattern();
            StrategyPresenter.PresentPattern();

            Console.ReadLine();
        }
    }
}
