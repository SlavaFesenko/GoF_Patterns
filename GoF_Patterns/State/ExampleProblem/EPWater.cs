
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.State.ExampleProblem
{
    public enum WaterState
    {
        Solid,
        Liquid,
        Gas
    }

    public class EPWater
    {
        public WaterState State { get; set; }

        public EPWater(WaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            if (State == WaterState.Solid)
            {
                Console.WriteLine("Transfer state into Liquid");
                State = WaterState.Liquid;
            }
            else if (State == WaterState.Liquid)
            {
                Console.WriteLine("Transfer state into Gas");
                State = WaterState.Gas;
            }
            else if (State == WaterState.Gas)
            {
                Console.WriteLine("Increase Gas temperature");
            }
        }

        public void Frost()
        {
            if (State == WaterState.Solid)
            {
                Console.WriteLine("Decrease ice temperature");
            }
            else if (State == WaterState.Liquid)
            {
                Console.WriteLine("Transfer state into Solid");
                State = WaterState.Solid;
            }
            else if (State == WaterState.Gas)
            {
                Console.WriteLine("Transfer Gas into Liquid");
                State = WaterState.Liquid;
            }
        }
    }
}
