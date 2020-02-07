using System;

namespace GoF_Patterns.Command.ExampleProblem
{
    public class MarketerReceiver
    {
        public void StartMarketing()
        {
            Console.WriteLine("StartMarketing");
        }

        public void StopMarketing()
        {
            Console.WriteLine("StopMarketing");
        }
    }
}
