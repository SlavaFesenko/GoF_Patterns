using System;

namespace GoF_Patterns.Facade.OwnExample
{
    class SmsService : ISendService
    {
        public SendServiceType GetServiceType()
        {
            return SendServiceType.Sms;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{GetServiceType().ToString()} service send message: {message}");
        }
    }
}