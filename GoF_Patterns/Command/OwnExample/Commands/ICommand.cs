namespace GoF_Patterns.Command.OwnExample.Commands
{
    public interface ICommand
    {
        bool IsExecutionPossible();
        void Execute();
        void Undo();
    }
}
