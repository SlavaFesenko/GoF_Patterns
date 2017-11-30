using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Decorator.ExampleProblem
{
    class Pizza
    {
        public int Cost { get; set; }
        public string Name { get; set; }
    }

    class ItalianPizza : Pizza
    {
        public ItalianPizza()
        {
            Cost = 25;
            Name = "Italian pizza";
        }
    }

    class ItalianPizzaWithTomato : Pizza
    {
        public ItalianPizzaWithTomato()
        {
            Cost = 30;
            Name = "Italian Pizza With Tomato";
        }
    }

    class ItalianPizzaWithTomatoAndCheese : Pizza
    {
        public ItalianPizzaWithTomatoAndCheese()
        {
            Cost = 35;
            Name = "Italian Pizza With Tomato and Cheese";
        }
    }
}
