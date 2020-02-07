using System;

namespace GoF_Patterns.Command.Example
{
    class DefaultCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("throw new NotImplementedException();"); 
        }

        public bool IsExecutionPossible()
        {
            Console.WriteLine("throw new NotImplementedException();");
            return true;
        }

        public void Undo()
        {
            Console.WriteLine("throw new NotImplementedException();");
        }
    }
}
