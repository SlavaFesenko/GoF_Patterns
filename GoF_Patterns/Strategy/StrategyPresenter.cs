using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Strategy.Realizations;

namespace GoF_Patterns.Strategy
{
    public static class StrategyPresenter
    {
        public static void PresentPattern()
        {
            Car car = new Car(new PatrolMove());
            car.MoveAhead();
            // case when we need to use another type
            car.ChangeMoveType(new ElectricMove());
            car.MoveAhead();
        }
    }
}
