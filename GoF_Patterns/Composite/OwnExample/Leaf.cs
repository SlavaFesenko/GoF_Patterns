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
            string separator = CompositeUtils.GetDepthSeparator(depth);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{separator}#{Id}: '{Name}':");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            separator = CompositeUtils.GetDepthSeparator(depth + 1);
            foreach (var usId in UssIds)
            {
                Console.WriteLine($"{separator} US #{usId};");
            }
            Console.ResetColor();
        }

        public override void Add(AComponent child)
        {
            throw new NotImplementedException();
        }

        public override void Delete(AComponent child)
        {
            throw new NotImplementedException();
        }
    }
}
