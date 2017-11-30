namespace GoF_Patterns.Strategy.OwnExample
{
    struct OutputData
    {
        public OutputData(double p, string stepSolution)
        {
            P = p;
            StepSolution = stepSolution;
        }
        public double P { get; set; }
        public string StepSolution { get; set; }
    }
}