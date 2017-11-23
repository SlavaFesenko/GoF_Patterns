﻿using System;
using GoF_Patterns.Facade.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Facade
{
    public static class FacadePresenter
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
            var facade = new VsIdeFacade(new Clr(), new Compiler(), new TextEditor());
            var client = new ProgrammerClient(facade);
            client.UsePattern();
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
