using System;
using GoF_Patterns.Bridge.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Bridge
{
    class BridgePresenter: IPresenter
    {
        public void PresentExample()
        {
            Programmer freelancer = new FreelanceProgrammer(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();
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
