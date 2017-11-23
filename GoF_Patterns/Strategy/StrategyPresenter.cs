using System;
using GoF_Patterns.Strategy.Example;
using GoF_Patterns.Strategy.Example.Realizations;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Strategy
{
    static class StrategyPresenter
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
            Car car = new Car(new PatrolMove());
            car.MoveAhead();
            // case when we need to use another type
            car.ChangeMoveType(new ElectricMove());
            car.MoveAhead();
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
