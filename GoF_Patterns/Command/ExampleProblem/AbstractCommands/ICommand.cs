namespace GoF_Patterns.Command.ExampleProblem
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
