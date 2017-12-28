using System;
using GoF_Patterns.Proxy.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Proxy
{
    static class ProxyPresenter
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
            throw new NotImplementedException();
        }

        private static void PresentExampleProblem()
        {
            throw new NotImplementedException();
        }

        private static void PresentOwnExample()
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

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
