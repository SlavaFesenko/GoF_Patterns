using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Decorator.Example.Training
{
    abstract class APizza
    {
        protected APizza(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract int GetCost();
    }

    abstract class APizzaDecorator : APizza
    {
        protected APizza Pizza;

        protected APizzaDecorator(string name, APizza pizza): base(name)
        {
            Pizza = pizza;
        }
    }

    class TomatoPizza : APizzaDecorator
    {
        public TomatoPizza(APizza pizza) : base(" with tomato", pizza)  { }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }

    class ItalianPizza: APizza
    {
        public ItalianPizza():base("Italian Pizza")  {  }
        public override int GetCost()
        {
            return 10;
        }
    }
}
