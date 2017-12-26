using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF_Patterns.Decorator.Example;
using GoF_Patterns.Decorator.OwnExample;
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
            pizza1 = new TomatoPizza(pizza1); // Italian pizza with tomato
            Console.WriteLine($"Name: {pizza1.Name}, cost: {pizza1.GetCost()}");

            APizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2); // Italian pizza with cheese
            Console.WriteLine($"Name: {pizza2.Name}, cost: {pizza2.GetCost()}");

            APizza pizza3 = new BulgerianPizza();
            pizza3 = new CheesePizza(pizza3); // Bulgarian pizza with cheese
            pizza3 = new TomatoPizza(pizza3); // Bulgarian pizza with cheese with tomato
            Console.WriteLine($"Name: {pizza3.Name}, cost: {pizza3.GetCost()}");
        }

        private static void PresentExampleProblem()
        {
            // огромная иерархия наследования, и то, далеко не все варианты
            ExampleProblem.ItalianPizza pizza = new ExampleProblem.ItalianPizza();
            Console.WriteLine($"Name: {pizza.Name}, cost: {pizza.Cost}");
        }

        private static void PresentOwnExample()
        {
            ASpell flyingDragon = new DamageSpell("Flying Dragon");
            flyingDragon = new FireElemental(flyingDragon);
            flyingDragon = new FireElemental(flyingDragon);

            //flyingDragon = new WaterElemental(flyingDragon);
            //flyingDragon = new EarthElemental(flyingDragon);
            flyingDragon = new AirElemental(flyingDragon);

            Console.WriteLine($"The spell '{flyingDragon.Name}' damaged:" +
                              $" fire = {flyingDragon.FirePoints()}; " +
                              $" water = {flyingDragon.WaterPoints()}; " +
                              $" earth = {flyingDragon.EarthPoints()}; " +
                              $" air = {flyingDragon.AirPoints()};");

            ASpell iceWall = new DefensiveSpell("Ice wall");
            iceWall = new WaterElemental(iceWall);

            Console.WriteLine($"The spell '{iceWall.Name}' defensed:" +
                              $" fire = {iceWall.FirePoints()}; " +
                              $" water = {iceWall.WaterPoints()}; " +
                              $" earth = {iceWall.EarthPoints()}; " +
                              $" air = {iceWall.AirPoints()};");
        }

        private static void PresentOwnProblem()
        {
            throw new NotImplementedException();
        }
    }
}
