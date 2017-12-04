using System;

namespace GoF_Patterns.State.Example
{
    public class LiquidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("liquid to solid");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Liquid to gas");
            water.State = new GasWaterState();
        }
    }
}