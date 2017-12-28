namespace GoF_Patterns.Adapter.Example
{
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}