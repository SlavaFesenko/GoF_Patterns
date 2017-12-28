using System;
using GoF_Patterns.Proxy.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Proxy
{
    class ProxyPresenter : IPresenter
    {
        public void PresentExample()
        {
            throw new NotImplementedException();
        }

        public void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentOwnExample()
        {
            ASubject logStorage = new LogStorageProxy();
            var page = logStorage.GetPage(0);
            Console.WriteLine(page);
            page = logStorage.GetPage(0);
            Console.WriteLine(page);

            page = logStorage.GetPage(2);
            Console.WriteLine(page);
            page = logStorage.GetPage(2);
            Console.WriteLine(page);
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
