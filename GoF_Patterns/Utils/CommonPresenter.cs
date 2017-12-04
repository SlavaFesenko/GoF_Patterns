using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.AbstractFactory;
using GoF_Patterns.Decorator;
using GoF_Patterns.Facade;
using GoF_Patterns.Memento;
using GoF_Patterns.State;
using GoF_Patterns.Strategy;

namespace GoF_Patterns.Utils
{

    static class CommonPresenter
    {
        public static void Present(PatternType patternType, PresentType presentType)
        {
            switch (patternType)
            {
                case PatternType.Decorator: DecoratorPresenter.Present(presentType); break;
                case PatternType.Facade: FacadePresenter.Present(presentType); break;
                case PatternType.Strategy: StrategyPresenter.Present(presentType); break;
                case PatternType.AbstractFactory: AbstractFactoryPresenter.Present(presentType); break;
                case PatternType.Memento: MementoPresenter.Present(presentType); break;
                case PatternType.State: StatePresenter.Present(presentType);  break;
            }
        }
    }


}
