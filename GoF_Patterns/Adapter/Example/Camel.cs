using System;

namespace GoF_Patterns.Adapter.Example
{
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel is going on send");
        }
    }
}