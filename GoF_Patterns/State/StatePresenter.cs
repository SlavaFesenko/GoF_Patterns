using System;
using GoF_Patterns.State.Example;
using GoF_Patterns.State.ExampleProblem;
using GoF_Patterns.State.OwnExample;
using GoF_Patterns.State.OwnProblem;
using GoF_Patterns.Utils;

namespace GoF_Patterns.State
{
    class StatePresenter : IPresenter
    {
        public void PresentExample()
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
        }

        public void PresentExampleProblem()
        {
            EPWater water = new EPWater(WaterState.Liquid);
            water.Frost();
            water.Frost();
            water.Heat();
        }

        public void PresentOwnExample()
        {
            OeCrupier croupier = new OeCrupier(new NewDeckState());
            for (int i = 0; i < 10; i++)
            {
                croupier.GetCard();
            }
        }

        public void PresentOwnProblem()
        {
            Croupier croupier = new Croupier();
            for (int i = 0; i < 10; i++)
            {
                croupier.GetCard();
            }
        }
    }
}
