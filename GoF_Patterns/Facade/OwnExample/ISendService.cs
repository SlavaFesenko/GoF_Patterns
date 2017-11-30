namespace GoF_Patterns.Facade.OwnExample
{
    public interface ISendService
    {
        void Send(string message);
        SendServiceType GetServiceType();

    }
}