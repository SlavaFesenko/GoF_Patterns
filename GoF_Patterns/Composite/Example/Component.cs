using System;

namespace GoF_Patterns.Composite.Example
{
    abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine(Name);
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

    }
}
