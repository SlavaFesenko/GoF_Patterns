using System;

namespace GoF_Patterns.State.OwnExample
{
    public class NewDeckState : IDeckState
    {
        public void GetCard(OeCrupier crupier)
        {
            Console.WriteLine("Deck is new, we need to reverse it!");
            // reversing deck
            crupier.State = new ReadyDeckState();
        }
    }
}