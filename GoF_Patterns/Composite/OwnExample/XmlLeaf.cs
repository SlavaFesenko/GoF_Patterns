using System;

namespace GoF_Patterns.Composite.OwnExample
{
    class XmlLeaf : XmlComponent
    {
        public XmlLeaf(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"Leaf name: {Name}");
        }
    }
}