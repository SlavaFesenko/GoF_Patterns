using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Strategy.OwnExample
{
    class ProbabilityCalculator
    {
        private ICalculationApproach _calculationApproach;

        public ProbabilityCalculator(ICalculationApproach calculationApproach)
        {
            _calculationApproach = calculationApproach;
        }

        public OutputData Calculate(InputData inputData)
        {
            return _calculationApproach.Calculate(inputData);
        }

        public void ChangeApproach(ICalculationApproach newCalculationApproach)
        {
            _calculationApproach = newCalculationApproach;
        }
    }
}
