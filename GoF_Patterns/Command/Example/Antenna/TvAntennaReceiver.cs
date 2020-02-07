using System;

namespace GoF_Patterns.Command.Example
{
    public class TvAntennaReceiver
    {
        bool _isTurnedOff = true;

        public bool IsTurnedOff()
        {
            return _isTurnedOff;
        }

        public void TurnOn()
        {
            _isTurnedOff = true;

            Console.WriteLine("Antenna turned On");
        }

        public void TurnOff()
        {
            _isTurnedOff = false;

            Console.WriteLine("Antenna turned Off");
        }
    }
}
