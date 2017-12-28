using System;
using GoF_Patterns.Adapter.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Adapter
{
    class AdapterPresenter : IPresenter
    {
        public void PresentExample()
        {
            Driver driver = new Driver();

            driver.Travel(new Auto());

            var camelTransport = new CamelToTransportAdapter(new Camel());

            driver.Travel(camelTransport);
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
