using System;
using GoF_Patterns.Command.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Template
{
    class CommandPresenter: IPresenter
    {
        public void PresentExample()
        {
            RemoteControlInvoker rci = new RemoteControlInvoker();

            TVReceiver tv = new TVReceiver();
            ICommand tvOnCommand = new TvOnCommand(tv);
            rci.SetCommand(tvOnCommand);
            if (rci.IsExecutionPossible())
                rci.PressTurnOnButton();
            rci.PressTurnOffButton();

            TvAntennaReceiver tvAntennaReceiver = new TvAntennaReceiver();
            ICommand antennaOnCommand = new AntennaOnCommand(tvAntennaReceiver);
            rci.SetCommand(antennaOnCommand);
            if (rci.IsExecutionPossible())
                rci.PressTurnOnButton();
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
