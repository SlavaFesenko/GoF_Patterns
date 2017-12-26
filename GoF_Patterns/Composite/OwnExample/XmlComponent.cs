using System;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.Composite.OwnExample
{
    abstract class XmlComponent
    {
        protected string Name;

        protected XmlComponent(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Node: {Name}");
        }

        public virtual void Add(XmlComponent component) { }

        public virtual void Remove(XmlComponent component) { }

    }
}
