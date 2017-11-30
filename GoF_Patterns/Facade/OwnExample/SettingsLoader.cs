using System.Collections.Generic;

namespace GoF_Patterns.Facade.OwnExample
{
    class SettingsLoader : ISettingsLoader
    {
        public IEnumerable<SendServiceType> LoadSettings(int clientId)
        {
            // получение данных из бд по clientId, формируем на их основе массив
            return new List<SendServiceType>()
            {
                SendServiceType.Email,
                //SendServiceType.Push,
                SendServiceType.Sms
            };
        }
    }
}