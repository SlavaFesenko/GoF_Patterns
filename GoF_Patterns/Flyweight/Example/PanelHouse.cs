using System;

namespace GoF_Patterns.Flyweight.Example
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Stages = 16;
        }

        public override void Build(double longtitude, double latitude)
        {
            Console.WriteLine($"Panel house with {Stages} stages. Ln = {longtitude}, Lt = {latitude}");
        }
    }
}