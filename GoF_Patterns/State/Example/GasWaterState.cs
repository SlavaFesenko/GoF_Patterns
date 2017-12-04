using System;

namespace GoF_Patterns.State.Example
{
    public class GasWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Gas to liquid");
            water.State = new LiquidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Gas to gas");
        }
    }
}