using System;

namespace GoF_Patterns.Facade.OwnExample
{
    class PushService : ISendService
    {
        public SendServiceType GetServiceType()
        {
            return SendServiceType.Push;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{GetServiceType().ToString()} service send message: {message}");
        }
    }
}