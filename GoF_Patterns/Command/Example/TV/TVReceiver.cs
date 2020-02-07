using System;

namespace GoF_Patterns.Command.Example
{
    public class TVReceiver
    {
        bool _isTurnedOff = true;

        public bool IsTurnededOff()
        {
            return _isTurnedOff;
        }

        public void TurnOn()
        {
            _isTurnedOff = true;

            Console.WriteLine("TV turned On");
        }

        public void TurnOff()
        {
            _isTurnedOff = false;

            Console.WriteLine("TV turned Off");
        }
    }
}
