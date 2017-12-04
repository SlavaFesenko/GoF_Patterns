using System;

namespace GoF_Patterns.State.OwnExample
{
    public class ReadyDeckState : IDeckState
    {
        public void GetCard(OeCrupier crupier)
        {
            Console.WriteLine("Deck is ready, take a card!");
            // giving a card
            crupier.CardCount--;
            crupier.State = new InUseDeckState();
        }
    }
}