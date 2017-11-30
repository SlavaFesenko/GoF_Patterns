namespace GoF_Patterns.Strategy.OwnExample
{
    class PuassonApproach : ICalculationApproach
    {
        public OutputData Calculate(InputData inputData)
        {
            // calculations 
            return new OutputData(0.21, "Step-by-step solution by PuassonApproach");
        }
    }
}