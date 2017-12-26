using System;
using System.Collections.Generic;

namespace GoF_Patterns.Composite.OwnExample
{
    class XmlNode : XmlComponent
    {
        private List<XmlComponent> _childComponents = new List<XmlComponent>();
        public XmlNode(string name) : base(name)  { }

        public override void Add(XmlComponent component)
        {
            _childComponents.Add(component);
        }

        public override void Remove(XmlComponent component)
        {
            _childComponents.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Node name: {Name}");
            if (_childComponents.Count == 0)
                return;

            Console.WriteLine("Child nodes: ");
            foreach (var childComponent in _childComponents)
            {
                childComponent.Print();
            }
        }
    }
}