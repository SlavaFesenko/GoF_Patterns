namespace GoF_Patterns.Strategy.OwnExample
{
    struct InputData
    {
        public InputData(double k, double l, double n, bool needStepSolution)
        {
            K = k; N = n; L = l;
            NeedStepSolution = needStepSolution;
        }
        public double K { get; set; }
        public double L { get; set; }
        public double N { get; set; }
        public bool NeedStepSolution { get; set; }

    }
}