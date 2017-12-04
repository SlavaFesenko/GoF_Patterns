using System;

namespace GoF_Patterns.State.OwnExample
{
    public class FinishedDeckState : IDeckState
    {
        public void GetCard(OeCrupier crupier)
        {
            Console.WriteLine("Deck is finished, taking a new deck!");
            crupier.State = new NewDeckState();
        }
    }
}