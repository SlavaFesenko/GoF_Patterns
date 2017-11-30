using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade.OwnExample
{
    class OeClient
    {
        private readonly NotificationServiceFactory _factory;
        private int _clientId;
        public OeClient(NotificationServiceFactory factory)
        {
            _factory = factory;
            _clientId = 5; // data from db
        }

        public void SendMessage()
        {
            var message = "Send this";
            _factory.SendNotification(message, _clientId);
        }
    }
}
