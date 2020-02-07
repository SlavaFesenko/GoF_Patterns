using System;

namespace GoF_Patterns.Command.ExampleProblem
{
    public class ProgrammerReceiver
    {
        public void StartCoding()
        {
            Console.WriteLine("StartCoding");
        }

        public void StopCoding()
        {
            Console.WriteLine("StopCoding");
        }
    }
}
