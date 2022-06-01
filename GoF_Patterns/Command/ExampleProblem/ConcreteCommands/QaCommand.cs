namespace GoF_Patterns.Command.ExampleProblem.ConcreteCommands
{
    public class QaCommand : ICommand
    {
        QaReceiver _qaReceiver = new QaReceiver();

        public void Execute()
        {
            _qaReceiver.StartTestingProject();
        }

        public void Undo()
        {
            _qaReceiver.StopTestingProject();
        }
    }
}
