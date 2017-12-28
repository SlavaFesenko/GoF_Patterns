using System;
using System.Collections.Generic;
using GoF_Patterns.Facade.Example;
using GoF_Patterns.Facade.ExampleProblem;
using GoF_Patterns.Facade.OwnExample;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Facade
{
    public class FacadePresenter : IPresenter
    {
        public void PresentExampleProblem()
        {
            EpClient.UsePattern(new Clr(), new TextEditor(), new Compiler());
        }

        public void PresentOwnExample()
        {
            var factory = new NotificationServiceFactory(
                new List<ISendService>() { new EmailService(), new PushService(), new SmsService() },
                new SettingsLoader());
            OeClient client = new OeClient(factory);
            client.SendMessage();
        }

        public void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }

        public void PresentExample()
        {
            var facade = new VsIdeFacade(new Clr(), new Compiler(), new TextEditor());
            var client = new ProgrammerClient(facade);
            client.UsePattern();
        }
    }
}
