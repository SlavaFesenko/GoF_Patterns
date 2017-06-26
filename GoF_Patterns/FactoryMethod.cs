using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns
{
    // Фабричный метод (Factory Method) - это порождающий паттерн, который определяет интерфейс для создания объектов некоторого класса, но непосредственное решение о том,
    // объект какого класса создавать происходит в подклассах.То есть паттерн предполагает, что базовый класс делегирует создание объектов классам-наследникам.
    // Когда надо применять паттерн:
    // - Когда заранее неизвестно, объекты каких типов необходимо создавать
    // - Когда система должна быть независимой от процесса создания новых объектов и расширяемой: в нее можно легко вводить новые классы, объекты которых система должна создавать.
    // - Когда создание новых объектов необходимо делегировать из базового класса классам наследникам

    // Creator, абстактный класс строительной компании

    //static void Main(string[] args)
    //{
    //    Developer dev = new PanelDeveloper("ООО КирпичСтрой");
    //    House panelHouse = dev.Create();

    //    dev = new WoodDeveloper("Частный застройщик");
    //    House woodHouse = dev.Create();

    //    Console.ReadLine();
    //}

    #region Creator

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }

        // фабричный метод
        abstract public House Create();
    }

    #endregion

    #region Concrete creators

    // ConcreteCreator1
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    // ConcreteCreator2
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    #endregion

    #region Product

    // Product, то есть конечный продукт
    abstract class House { }

    #endregion

    #region Concrete Products

    // ConcreteProduct1
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house was built!");
        }    

    }

    // ConcreteProduct2
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house was built!");
        }

    }

    #endregion
}
