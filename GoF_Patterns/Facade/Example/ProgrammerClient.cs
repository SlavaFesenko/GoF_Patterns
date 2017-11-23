using GoF_Patterns.Facade.Example.Interfaces;

namespace GoF_Patterns.Facade.Example
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
