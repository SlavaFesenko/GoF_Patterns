using System;
using GoF_Patterns.Command.Example;
using GoF_Patterns.Command.Example.TV;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Template
{
    class CommandPresenter: IPresenter
    {
        public void PresentExample()
        {
            RemoteControlInvoker rci = new RemoteControlInvoker(3);
            rci.PressTurnOnButton(0);

            TVReceiver tv = new TVReceiver();
            ICommand tvOnCommand = new TvOnCommand(tv);
            rci.SetCommand(0, tvOnCommand);
            if (rci.IsExecutionPossible(0))
                rci.PressTurnOnButton(0);
            rci.PressTurnOffButton();

            ICommand volumeCommand = new VolumeCommand(tv);
            rci.SetCommand(1, volumeCommand);
            if (rci.IsExecutionPossible(1))
                rci.PressTurnOnButton(1);
            rci.PressTurnOffButton();

            TvAntennaReceiver tvAntennaReceiver = new TvAntennaReceiver();
            ICommand antennaOnCommand = new AntennaOnCommand(tvAntennaReceiver);
            rci.SetCommand(2, antennaOnCommand);
            if (rci.IsExecutionPossible(2))
                rci.PressTurnOnButton(2);
            rci.PressTurnOffButton();
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
