using System;
using GoF_Patterns.Memento.Example;
using GoF_Patterns.Memento.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Memento
{
    static class MementoPresenter
    {
        public static void Present(PresentType presentType)
        {
            switch (presentType)
            {
                case PresentType.Example: PresentExample(); break;
                case PresentType.ExampleProblem: PresentExampleProblem(); break;
                case PresentType.OwnExample: PresentOwnExample(); break;
                case PresentType.OwnProblem: PresentOwnExample(); break;
            }
        }

        private static void PresentExample()
        {
            HeroOriginator hero = new HeroOriginator(); // 10 cartidges
            hero.Shoot(); // 9 cartidges
            GameHistoryCaretaker game = new GameHistoryCaretaker();

            game.History.Push(hero.SaveState()); // Save game
            hero.Shoot(); // 8 cartidges remaining

            hero.RestoreState(game.History.Pop()); // 9 cartidges
            hero.Shoot(); // 8 cartidges
        }

        private static void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        private static void PresentOwnExample()
        {
            TownOriginator town = new TownOriginator(); // 10
            town.Interact(5);  // 15
            TownCheckPointsCaretaker careTaker = new TownCheckPointsCaretaker();
            careTaker.TownCheckPoints.Push(town.SaveTown());
            town.Interact(-10); // 5
            town.RestoreTown(careTaker.TownCheckPoints.Pop()); // 15
        }

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
