using System;
using GoF_Patterns.Command.Example;
using GoF_Patterns.Command.Example.TV;
using GoF_Patterns.Command.ExampleProblem;
using GoF_Patterns.Command.ExampleProblem.AbstractCommands;
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
            GoF_Patterns.Command.Example.ICommand tvOnCommand = new TvOnCommand(tv);
            rci.SetCommand(0, tvOnCommand);
            if (rci.IsExecutionPossible(0))
                rci.PressTurnOnButton(0);
            rci.PressTurnOffButton();

            GoF_Patterns.Command.Example.ICommand volumeCommand = new VolumeCommand(tv);
            rci.SetCommand(1, volumeCommand);
            if (rci.IsExecutionPossible(1))
                rci.PressTurnOnButton(1);
            rci.PressTurnOffButton();

            TvAntennaReceiver tvAntennaReceiver = new TvAntennaReceiver();
            GoF_Patterns.Command.Example.ICommand antennaOnCommand = new AntennaOnCommand(tvAntennaReceiver);
            rci.SetCommand(2, antennaOnCommand);
            if (rci.IsExecutionPossible(2))
                rci.PressTurnOnButton(2);
            rci.PressTurnOffButton();
        }

        public void PresentExampleProblem()
        {
            ManagerInvoker manager = new ManagerInvoker();
            manager.SetCommand(new MacroCommand());
            manager.StartProject();
            manager.StopProject();
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
