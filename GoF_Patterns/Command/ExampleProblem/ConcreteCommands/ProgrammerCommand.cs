namespace GoF_Patterns.Command.ExampleProblem.ConcreteCommands
{
    public class ProgrammerCommand : ICommand
    {
        ProgrammerReceiver _programmerReceiver = new ProgrammerReceiver();

        public void Execute()
        {
            _programmerReceiver.StartCoding();
        }

        public void Undo()
        {
            _programmerReceiver.StopCoding();
        }
    }
}
