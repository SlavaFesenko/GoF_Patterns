using System;
using GoF_Patterns.AbstractFactory.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.AbstractFactory
{
    static class AbstractFactoryPresenter
    {
        public static void Present(PresentType presentType)
        {
            switch (presentType)
            {
                case PresentType.Example: PresentExample(); break;
                case PresentType.ExampleProblem: PresentExampleProblem(); break;
                case PresentType.OwnExample: PresentOwnExample(); break;
                case PresentType.OwnProblem: PresentOwnExample(); break;
            }
        }

        private static void PresentExample()
        {
            Hero elven = new Hero(new ElvenFactory());
            elven.Hit();
            elven.Run();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();
        }

        private static void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        private static void PresentOwnExample()
        {
            throw new NotImplementedException();
        }

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
