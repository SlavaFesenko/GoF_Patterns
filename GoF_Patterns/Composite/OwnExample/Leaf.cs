using System;
using System.Collections.Generic;

namespace GoF_Patterns.Composite.OwnExample
{
    [Serializable]
    public class Leaf : AComponent
    {
        public List<int> UssIds = new List<int>();

        public Leaf() : base() { }
        public Leaf(int hierarchyId, string hierarchyName) : base(hierarchyId, hierarchyName) { }

      
        public void AddUsId(int usid)
        {
            UssIds.Add(usid);
        }

        public override void Print(int depth = 0)
        {
            string separator = GetDepthSeparator(depth);
            Console.WriteLine($"{separator}#{Id}: {Name}:");

            foreach (var usId in UssIds)
            {
                Console.WriteLine($"{separator} US #{usId};");
            }
        }

        public override void Add(int componentHierarchyId)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int componentHierarchyId)
        {
            throw new NotImplementedException();
        }
    }
}
