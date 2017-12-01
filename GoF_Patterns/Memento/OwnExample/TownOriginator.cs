using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Memento.OwnExample
{
    class TownOriginator
    {
        private int _towersCount = 10;

        public void Interact(int towers)
        {
            _towersCount += towers;
            Console.WriteLine(towers < 0
                ? $"Damage! {_towersCount} towers remaining!"
                : $"Towers repaired! {_towersCount} towers present");
        }

        public TownMemento SaveTown()
        {
            Console.WriteLine($"Saving the town... {_towersCount} towers");
            return new TownMemento(){ TowersCount = _towersCount};
        }

        public void RestoreTown(TownMemento memento)
        {
            _towersCount = memento.TowersCount;
            Console.WriteLine($"Restoring town... {_towersCount} towers");
        }
    }
}
