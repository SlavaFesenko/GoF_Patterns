using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GoF_Patterns.Composite.OwnExample
{
    [Serializable]
    public class Composite : AComponent
    {
        private ComponentsRepository _repo = new ComponentsRepository();
        public List<int> ChildsIds = new List<int>();

        public Composite() : base() { }
        public Composite(int hierarchyId, string hierarchyName) : base(hierarchyId, hierarchyName) { }
        
        public override void Add(AComponent child)
        {
            child.ParentId = Id;
            ChildsIds.Add(child.Id);
        }

        public override void Delete(AComponent child)
        {
            ChildsIds.Remove(child.Id);
        }

        public override void Print(int depth = 0)
        {
            string separator = CompositeUtils.GetDepthSeparator(depth);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{separator}#{Id}: '{Name}':");
            Console.ResetColor();

            foreach (var id in ChildsIds)
            {
                var component = _repo.GetAComponentById(id);
                component.Print(depth + 1);
            }
        }
    }
}
