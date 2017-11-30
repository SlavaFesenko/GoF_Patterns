using System.Collections.Generic;

namespace GoF_Patterns.Facade.OwnExample
{
    class NotificationServiceFactory
    {
        private readonly List<ISendService> _sendServices;
        private readonly ISettingsLoader _settingsLoader;

        public NotificationServiceFactory(List<ISendService> sendServices, ISettingsLoader settingsLoader)
        {
            _sendServices = sendServices;
            _settingsLoader = settingsLoader;
        }

        public void SendNotification(string message, int clientId)
        {
            // куда уведомлять данного клиента, например, только Email
            var sendCases = _settingsLoader.LoadSettings(clientId);

            foreach (var service in _sendServices)
            {
                // определяем, что за сервис нам доступен
                var serviceType = service.GetServiceType();

                foreach (var sendCase in sendCases)
                {
                    // если доступный сервис совпадает с настройками - отпавляем
                    if (sendCase == serviceType)
                    {
                        service.Send(message);
                    }
                }

            }
        }
    }
}