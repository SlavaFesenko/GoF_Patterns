namespace GoF_Patterns.Adapter.Example
{
    class CamelToTransportAdapter : ITransport
    {
        private readonly Camel _camel;

        public CamelToTransportAdapter(Camel c)
        {
            _camel = c;
        }

        public void Drive()
        {
            _camel.Move();
        }
    }
}