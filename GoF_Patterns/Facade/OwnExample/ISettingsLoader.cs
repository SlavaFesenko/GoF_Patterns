using System.Collections.Generic;

namespace GoF_Patterns.Facade.OwnExample
{
    interface ISettingsLoader
    {
        IEnumerable<SendServiceType> LoadSettings(int clientId);
    }
}