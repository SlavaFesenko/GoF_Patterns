using System;
using GoF_Patterns.Strategy.Example;
using GoF_Patterns.Strategy.Example.Realizations;
using GoF_Patterns.Strategy.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Strategy
{
    class StrategyPresenter : IPresenter
    {
        public void PresentExample()
        {
            Car car = new Car(new PatrolMove());
            car.MoveAhead();
            // case when we need to use another type
            car.ChangeMoveType(new ElectricMove());
            car.MoveAhead();
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            ProbabilityCalculator calculator = new ProbabilityCalculator(new BernoulliApproach());
            var input = new InputData(5, 15, 45.5, true);
            var output = calculator.Calculate(input);
            Console.WriteLine($"Result: {output.P}; Step solution: {output.StepSolution}");

            calculator.ChangeApproach(new LaplasApproach());
            var output2 = calculator.Calculate(input);
            Console.WriteLine($"Result: {output2.P}; Step solution: {output2.StepSolution}");

            calculator.ChangeApproach(new PuassonApproach());
            var output3 = calculator.Calculate(input);
            Console.WriteLine($"Result: {output3.P}; Step solution: {output3.StepSolution}");
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
