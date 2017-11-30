namespace GoF_Patterns.Strategy.OwnExample
{
    class BernoulliApproach : ICalculationApproach
    {
        public OutputData Calculate(InputData inputData)
        {
            // calculations 
            return new OutputData(0.25, "Step-by-step solution by BernoulliApproach");
        }
    }
}