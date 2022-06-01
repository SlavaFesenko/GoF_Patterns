namespace GoF_Patterns.Command.Example
{
    public interface ICommand
    {
        bool IsExecutionPossible();
        void Execute();
        void Undo();
    }
}
