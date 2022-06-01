using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Command.Example.TV
{
    class VolumeCommand : ICommand
    {
        TVReceiver _tVReceiver;
        public VolumeCommand(TVReceiver tv)
        {
            _tVReceiver = tv;
        }

        public bool IsExecutionPossible()
        {
            return _tVReceiver.IsTurnedOn();
        }

        public void Execute()
        {
            _tVReceiver.IncreaseVolume();
        }

        public void Undo()
        {
            _tVReceiver.DecreaseVolume();
        }
    }
}
