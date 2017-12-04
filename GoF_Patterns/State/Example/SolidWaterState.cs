using System;

namespace GoF_Patterns.State.Example
{
    public class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("solid to solid");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("solid to liquid");
            water.State = new LiquidWaterState();
        }
    }
}