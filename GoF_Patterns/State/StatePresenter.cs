using System;
using GoF_Patterns.State.Example;
using GoF_Patterns.State.ExampleProblem;
using GoF_Patterns.State.OwnExample;
using GoF_Patterns.State.OwnProblem;
using GoF_Patterns.Utils;

namespace GoF_Patterns.State
{
    static class StatePresenter
    {
        public static void Present(PresentType presentType)
        {
            switch (presentType)
            {
                case PresentType.Example: PresentExample(); break;
                case PresentType.ExampleProblem: PresentExampleProblem(); break;
                case PresentType.OwnExample: PresentOwnExample(); break;
                case PresentType.OwnProblem: PresentOwnProblem(); break;
            }
        }

        private static void PresentExample()
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

        }

        private static void PresentExampleProblem()
        {
            EPWater water = new EPWater(WaterState.Liquid);
            water.Frost();
            water.Frost();
            water.Heat();
        }

        private static void PresentOwnExample()
        {
            OeCrupier croupier = new OeCrupier(new NewDeckState());
            for (int i = 0; i < 10; i++)
            {
                croupier.GetCard();
            }
        }

        private static void PresentOwnProblem()
        {
            Croupier croupier = new Croupier();
            for (int i = 0; i < 10; i++)
            {
                croupier.GetCard();
            }
            
        }
    }
}
