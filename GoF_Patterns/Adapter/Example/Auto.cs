using System;

namespace GoF_Patterns.Adapter.Example
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car is riding on the road");
        }
    }
}
