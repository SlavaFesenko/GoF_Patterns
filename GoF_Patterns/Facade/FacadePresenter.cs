using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade
{
    public static class FacadePresenter
    {
        public static void PresentPattern()
        {
            var facade = new VsIdeFacade(new Clr(), new Compiler(), new TextEditor());
            var client = new ProgrammerClient(facade);
            client.UsePattern();
        }
    }
}
