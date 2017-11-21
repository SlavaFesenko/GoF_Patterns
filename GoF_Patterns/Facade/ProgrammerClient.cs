using GoF_Patterns.Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Facade
{
    class ProgrammerClient
    {
        private readonly IFacade _facade;
        public ProgrammerClient(IFacade facade)
        {
            _facade = facade;
        }

        public void UsePattern()
        {
            _facade.ActionFirst();
            _facade.ActionSecond();
        }
    }
}
