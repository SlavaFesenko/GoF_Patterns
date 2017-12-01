using System.Collections.Generic;

namespace GoF_Patterns.Memento.OwnExample
{
    public class TownCheckPointsCaretaker
    {
        public Stack<TownMemento> TownCheckPoints { get; set; }

        public TownCheckPointsCaretaker()
        {
            TownCheckPoints = new Stack<TownMemento>();
        }
    }
}