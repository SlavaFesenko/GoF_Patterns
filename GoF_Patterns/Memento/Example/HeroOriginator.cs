using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Memento.Example
{
    class HeroOriginator
    {
        private int _cartidgesCount = 10;
        private int _livesCount = 5;

        public void Shoot()
        {
            if (_cartidgesCount > 0)
            {
                _cartidgesCount--;
                Console.WriteLine($"Shoot! {_cartidgesCount} cartidges remaining. ");
            }
            else
            {
                Console.WriteLine("No cartidges!");
            }
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine($"Game is saving... {_cartidgesCount} cartidges, {_livesCount} lives");
            return new HeroMemento(_cartidgesCount, _livesCount);
        }

        public void RestoreState(HeroMemento memento)
        {
            _cartidgesCount = memento.Cartidges;
            _livesCount = memento.Lives;
            Console.WriteLine($"Restoring game... {_cartidgesCount} cartidges, {_livesCount} lives");
        }

    }
}
