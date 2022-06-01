using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF_Patterns.Composite.OwnExample
{
    public class ComponentsRepository
    {
        public List<AComponent> GetAComponents()
        {
            return ComponentXmlSerializer.ReadUsList(Fetch());
        }

        public static List<AComponent> Fetch()
        {
            var c1 = new Composite(1, "Programming");
            var c3 = new Composite(3, "C#"); c1.Add(c3);
            var c5 = new Leaf(5, "Multicurrency"); c3.Add(c5);
            c5.AddUsId(26); c5.AddUsId(27);

            var c2 = new Composite(2, "Poker");
            var c4 = new Leaf(4, "Preflop"); c2.Add(c4);
            c4.AddUsId(5);

            var c0 = new Composite(0, "Object");
            c0.Add(c1); c0.Add(c2);

            return new List<AComponent>()
            {
                c0, c1, c2, c3, c4, c5
            };
        }

        public AComponent GetAComponentById(int id)
        {
            return GetAComponents().First(c => c.Id == id);
        }
    }
}
