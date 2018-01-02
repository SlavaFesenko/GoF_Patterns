using System;
using GoF_Patterns.Flyweight.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Flyweight
{
    class FlyweightPresenter: IPresenter
    {
        public void PresentExample()
        {
            var longtitude = 37.61;
            var latitude = 55.74;

            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                panelHouse?.Build(longtitude, latitude);
                longtitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");
                brickHouse?.Build(longtitude, latitude);
                longtitude += 0.1;
                latitude += 0.1;
            }
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
