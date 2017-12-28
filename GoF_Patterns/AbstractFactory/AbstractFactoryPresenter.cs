using System;
using GoF_Patterns.AbstractFactory.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.AbstractFactory
{
    class AbstractFactoryPresenter : IPresenter
    {
        void IPresenter.PresentExample()
        {
            Hero elven = new Hero(new ElvenFactory());
            elven.Hit();
            elven.Run();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();
        }

        void IPresenter.PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        void IPresenter.PresentOwnExample()
        {
            throw new NotImplementedException();
        }

        void IPresenter.PresentOwnProblem()
        {
            throw new NotImplementedException();
        }

    }
}
