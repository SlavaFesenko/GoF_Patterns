namespace GoF_Patterns.Command.ExampleProblem
{
    class ManagerInvoker
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void StartProject()
        {
            _command.Execute();
        }

        public void StopProject()
        {
            _command.Undo();
        }
    }
}
