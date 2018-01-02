using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoF_Patterns.Flyweight.Example
{
    abstract class House
    {
        protected int Stages;

        public abstract void Build(double longtitude, double latitude);
    }

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

    class HouseFactory
    {
        private Dictionary<string, House> _houses = new Dictionary<string, House>();

        public HouseFactory()
        {
            _houses.Add("Panel", new PanelHouse());
            _houses.Add("Brick", new PanelHouse());
        }

        public House GetHouse(string key)
        {
            if (_houses.ContainsKey(key))
            {
                return _houses[key];
            }
            else
            {
                return null;
            }
        }
    }
}
