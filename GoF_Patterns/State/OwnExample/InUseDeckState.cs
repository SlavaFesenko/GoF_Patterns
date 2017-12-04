using System;

namespace GoF_Patterns.State.OwnExample
{
    public class InUseDeckState : IDeckState
    {
        public void GetCard(OeCrupier crupier)
        {
            Console.WriteLine("Deck is in use, take a card!");
            // giving a card, while limit will be reached
            crupier.CardCount--;
            if (crupier.CardCount < 48)
            {
                crupier.State = new FinishedDeckState();
            }
        }
    }
}