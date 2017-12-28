using GoF_Patterns.AbstractFactory;
using GoF_Patterns.Composite;
using GoF_Patterns.Decorator;
using GoF_Patterns.Facade;
using GoF_Patterns.Memento;
using GoF_Patterns.Proxy;
using GoF_Patterns.State;
using GoF_Patterns.Strategy;
using GoF_Patterns.Template;

namespace GoF_Patterns.Utils
{

    static class PresenterFactory
    {
        public static IPresenter GetPresenter(PatternType patternType)
        {
            IPresenter presenter = new TemplatePresenter();

            switch (patternType)
            {
                case PatternType.Decorator: presenter = new DecoratorPresenter(); break;
                case PatternType.Facade: presenter = new FacadePresenter(); break;
                case PatternType.Strategy: presenter = new StrategyPresenter(); break;
                case PatternType.AbstractFactory: presenter = new AbstractFactoryPresenter(); break;
                case PatternType.Memento: presenter = new MementoPresenter(); break;
                case PatternType.State: presenter = new StatePresenter();  break;
                case PatternType.Composite: presenter = new CompositePresenter(); break;
                case PatternType.Proxy: presenter = new ProxyPresenter(); break;
            }

            return presenter;
        }
    }


}
