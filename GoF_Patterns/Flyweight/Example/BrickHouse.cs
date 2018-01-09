using System;

namespace GoF_Patterns.Flyweight.Example
{
    class BrickHouse : House
    {
        public BrickHouse()
        {
            Stages = 5;
        }

        public override void Build(double longtitude, double latitude)
        {
            Console.WriteLine($"Brick house with {Stages} stages. Ln = {longtitude}, Lt = {latitude}");
        }
    }
}