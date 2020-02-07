using System;

namespace GoF_Patterns.Command.Example
{
    public class TVReceiver
    {
        bool _isTurnedOn = true;

        int _currentVolume = 0;
        const int MinVolume = 0;
        const int MaxVolume = 1;

        public bool IsTurnedOn()
        {
            return _isTurnedOn;
        }

        public void TurnOn()
        {
            _isTurnedOn = true;

            Console.WriteLine("TV turned On");
        }

        public void TurnOff()
        {
            _isTurnedOn = false;

            Console.WriteLine("TV turned Off");
        }

        public void IncreaseVolume()
        {
            if (_currentVolume < MaxVolume)
                _currentVolume++;

            Console.WriteLine($"_currentVolume == {_currentVolume}");
        }

        public void DecreaseVolume()
        {
            if (_currentVolume > MinVolume)
                _currentVolume--;

            Console.WriteLine($"_currentVolume == {_currentVolume}");
        }
    }
}
