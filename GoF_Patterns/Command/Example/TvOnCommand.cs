using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Command.Example
{
    class TvOnCommand : ICommand
    {
        TVReceiver _tvReceiver;

        public TvOnCommand(TVReceiver tvReceiver)
        {
            _tvReceiver = tvReceiver;
        }

        public bool IsExecutionPossible()
        {
            return _tvReceiver.IsTurnededOff();
        }

        public void Execute()
        {
            _tvReceiver.TurnOn();
        }

        public void Undo()
        {
            _tvReceiver.TurnOff();
        }
    }
}
