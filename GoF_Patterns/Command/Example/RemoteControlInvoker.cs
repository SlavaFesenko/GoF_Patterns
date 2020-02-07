using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GoF_Patterns.Command.Example
{
    public class RemoteControlInvoker
    {
        private ICommand[] _commands;
        Stack<ICommand> _commandsLog = new Stack<ICommand>();

        public RemoteControlInvoker(int commandsCount)
        {
            _commands = new ICommand[commandsCount];

            for (int i = 0; i < _commands.Length; i++)
                _commands[i] = new DefaultCommand();
        }

        public void SetCommand(int commandNo, ICommand command)
        {
            _commands[commandNo] = command;
        }

        public bool IsExecutionPossible(int commandNo)
        {
            return _commands[commandNo].IsExecutionPossible();
        }

        public void PressTurnOnButton(int commandNo)
        {
            _commands[commandNo].Execute();
            _commandsLog.Push(_commands[commandNo]);
        }

        public void PressTurnOffButton()
        {
            if (_commandsLog?.Any() ?? true)
                _commandsLog.Pop().Undo();
        }
    }
}
