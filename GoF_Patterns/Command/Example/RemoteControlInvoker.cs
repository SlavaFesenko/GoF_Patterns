using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Command.Example
{
    public class RemoteControlInvoker
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public bool IsExecutionPossible()
        {
            return _command.IsExecutionPossible();
        }

        public void PressTurnOnButton()
        {
            _command.Execute();
        }

        public void PressTurnOffButton()
        {
            _command.Undo();
        }
    }
}
