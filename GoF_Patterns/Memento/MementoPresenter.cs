using System;
using GoF_Patterns.Memento.Example;
using GoF_Patterns.Memento.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Memento
{
    class MementoPresenter : IPresenter
    {
        public void PresentExample()
        {
            HeroOriginator hero = new HeroOriginator(); // 10 cartidges
            hero.Shoot(); // 9 cartidges
            GameHistoryCaretaker game = new GameHistoryCaretaker();

            game.History.Push(hero.SaveState()); // Save game
            hero.Shoot(); // 8 cartidges remaining

            hero.RestoreState(game.History.Pop()); // 9 cartidges
            hero.Shoot(); // 8 cartidges
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            TownOriginator town = new TownOriginator(); // 10
            town.Interact(5);  // 15
            TownCheckPointsCaretaker careTaker = new TownCheckPointsCaretaker();
            careTaker.TownCheckPoints.Push(town.SaveTown());
            town.Interact(-10); // 5
            town.RestoreTown(careTaker.TownCheckPoints.Pop()); // 15
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }

    }
}
