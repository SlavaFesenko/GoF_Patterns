namespace GoF_Patterns.Command.ExampleProblem.ConcreteCommands
{
    public class MarketerCommand : ICommand
    {
        MarketerReceiver _marketerReceiver = new MarketerReceiver();

        public void Execute()
        {
            _marketerReceiver.StartMarketing();
        }

        public void Undo()
        {
            _marketerReceiver.StopMarketing();
        }
    }
}
