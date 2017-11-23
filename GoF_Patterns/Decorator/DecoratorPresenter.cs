using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF_Patterns.Decorator.Example;
using GoF_Patterns.Utils;

namespace GoF_Patterns.Decorator
{
    static class DecoratorPresenter
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
            APizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            Console.WriteLine($"Name: {pizza1.Name}, cost: {pizza1.GetCost()}");

            APizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);
            Console.WriteLine($"Name: {pizza2.Name}, cost: {pizza2.GetCost()}");

            APizza pizza3 = new BulgerianPizza();
            pizza3 = new CheesePizza(pizza3); // Bulgarian pizza with cheese
            pizza3 = new TomatoPizza(pizza3); // Bulgarian pizza with cheese with tomato
            Console.WriteLine($"Name: {pizza3.Name}, cost: {pizza3.GetCost()}");
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
