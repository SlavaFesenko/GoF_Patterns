using System;
using System.Collections.Generic;

namespace GoF_Patterns.Composite.Example
{
    class Directory : Component
    {
        private List<Component> _components = new List<Component>();
        public Directory(string name) : base(name) { }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Current Node Name: {Name}");
            Console.WriteLine("Subnodes:  ");
            foreach (var component in _components)
            {
                component.Print();
            }
        }
    }
}