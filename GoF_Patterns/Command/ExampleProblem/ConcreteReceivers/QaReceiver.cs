using System;

namespace GoF_Patterns.Command.ExampleProblem
{
    public class QaReceiver
    {
        public void StartTestingProject()
        {
            Console.WriteLine("StartTestingProject");
        }

        public void StopTestingProject()
        {
            Console.WriteLine("StopTestingProject");
        }
    }
}
