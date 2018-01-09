using System.Collections.Generic;

namespace GoF_Patterns.Flyweight.Example
{
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