using System;

namespace GoF_Patterns.Facade.OwnExample
{
    class EmailService : ISendService
    {
        public SendServiceType GetServiceType()
        {
            return SendServiceType.Email;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{GetServiceType().ToString()} service send message: {message}");
        }
    }
}