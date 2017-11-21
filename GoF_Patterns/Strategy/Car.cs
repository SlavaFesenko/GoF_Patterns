using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Strategy.Interfaces;

namespace GoF_Patterns.Strategy
{
    public class Car
    {
        public int PassangersCount { get; set; }
        public string Model { get; set; }

        private IMovable _moveType;

        public Car(IMovable moveType)
        {
            _moveType = moveType;

            PassangersCount = 10;
            Model = "Toyota";
        }

        public void ChangeMoveType(IMovable moveType)
        {
            _moveType = moveType;
        }

        public void MoveAhead()
        {
            // some actions... 
            _moveType.Move();
        }
    }
}
