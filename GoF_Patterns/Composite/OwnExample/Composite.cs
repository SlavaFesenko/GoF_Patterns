using System;
using System.Collections.Generic;

namespace GoF_Patterns.Composite.OwnExample
{
    class Composite : AComponent
    {
        private ComponentsRepository _repo = new ComponentsRepository();
        public List<int> ChildsIds = new List<int>();

        public Composite(int hierarchyId, string hierarchyName) : base(hierarchyId, hierarchyName) { }
        
        public override void Add(int componentHierarchyId)
        {
            ChildsIds.Add(componentHierarchyId);
        }

        public override void Delete(int componentHierarchyId)
        {
            ChildsIds.Remove(componentHierarchyId);
        }

        public override void Print(int depth = 0)
        {
            string separator = GetDepthSeparator(depth);
            Console.WriteLine($"{separator}#{Id}: {Name}:");
            foreach (var id in ChildsIds)
            {
                var component = _repo.GetAComponentById(id);
                component.Print(depth + 1);
            }
        }
    }
}
