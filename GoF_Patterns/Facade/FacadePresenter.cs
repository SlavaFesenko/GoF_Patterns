using System;
using System.Collections.Generic;
using GoF_Patterns.Facade.Example;
using GoF_Patterns.Facade.ExampleProblem;
using GoF_Patterns.Facade.OwnExample;
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
            EpClient.UsePattern(new Clr(), new TextEditor(), new Compiler());
        }

        private static void PresentOwnExample()
        {
            var factory = new NotificationServiceFactory(
                new List<ISendService>() {new EmailService(), new PushService(), new SmsService()},
                new SettingsLoader());
            OeClient client = new OeClient(factory);
            client.SendMessage();
        }

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
