namespace GoF_Patterns.Command.Example
{
    public class AntennaOnCommand : ICommand
    {
        TvAntennaReceiver _tvAntenna;
        public AntennaOnCommand(TvAntennaReceiver tvAntenna)
        {
            _tvAntenna = tvAntenna;
        }

        public void Execute()
        {
            _tvAntenna.TurnOn();
        }

        public bool IsExecutionPossible()
        {
            return _tvAntenna.IsTurnedOff();
        }

        public void Undo()
        {
            _tvAntenna.TurnOff();
        }
    }
}
