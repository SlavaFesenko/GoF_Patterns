namespace GoF_Patterns.Strategy.OwnExample
{
    class LaplasApproach : ICalculationApproach
    {
        public OutputData Calculate(InputData inputData)
        {
            // calculations 
            return new OutputData(0.27, "Step-by-step solution by LaplasApproach");
        }
    }
}