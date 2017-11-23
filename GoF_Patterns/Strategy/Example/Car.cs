using GoF_Patterns.Strategy.Example.Interfaces;

namespace GoF_Patterns.Strategy.Example
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
