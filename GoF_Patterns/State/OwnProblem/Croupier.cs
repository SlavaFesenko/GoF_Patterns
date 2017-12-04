using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.State.OwnProblem
{
    public class Croupier
    {
        public DeckState State { get; set; }
        public int CardCount = 52;

        public Croupier()
        {
            State = DeckState.New;
        }

        public void GetCard()
        {
            if (State == DeckState.New)
            {
                Console.WriteLine("Deck is new, we need to reverse it!");
                // reversing deck
                State = DeckState.Ready;
            }
            else if (State == DeckState.Ready)
            {
                Console.WriteLine("Deck is ready, take a card!");
                // giving a card
                CardCount--;
                State = DeckState.InUse;
            }
            else if (State == DeckState.InUse)
            {
                Console.WriteLine("Deck is in use, take a card!");
                // giving a card, while limit will be reached
                CardCount--;
                if (CardCount < 48)
                {
                    State = DeckState.Finished;
                }
            }
            else if (State == DeckState.Finished)
            {
                Console.WriteLine("Deck is finished, taking a new deck!");
                State = DeckState.New;
            }
        }
    }
}
