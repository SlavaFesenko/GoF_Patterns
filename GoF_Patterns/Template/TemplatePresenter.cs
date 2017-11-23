using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Decorator.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Template
{
    static class TemplatePresenter
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
            throw new NotImplementedException();
        }

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
