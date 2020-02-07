using GoF_Patterns.Command.ExampleProblem.ConcreteCommands;
using System.Collections.Generic;

namespace GoF_Patterns.Command.ExampleProblem.AbstractCommands
{
    public class MacroCommand : ICommand
    {
        List<ICommand> _commands;
        public MacroCommand()
        {
            _commands = new List<ICommand>
            {
                new ProgrammerCommand(),
                new QaCommand(),
                new MarketerCommand(),
            };
        }
        public void Execute()
        {
            foreach (var cmd in _commands)
                cmd.Execute();
        }

        public void Undo()
        {
            foreach (var cmd in _commands)
                cmd.Undo();
        }
    }
}
