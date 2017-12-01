using System.Collections.Generic;

namespace GoF_Patterns.Memento.Example
{
    class GameHistoryCaretaker
    {
        public Stack<HeroMemento> History { get; private set; }

        public GameHistoryCaretaker()
        {
            History = new Stack<HeroMemento>();
        }
    }
}