﻿using System;
using System.Text;
using System.Xml.Serialization;

namespace GoF_Patterns.Composite.OwnExample
{
    [XmlInclude(typeof(Leaf))]
    [XmlInclude(typeof(Composite))]
    [Serializable]
    public abstract class AComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AComponent()
        {

        }

        public AComponent(int hierarchyId, string hierarchyName)
        {
            Id = hierarchyId;
            Name = hierarchyName;
        }

        public abstract void Print(int depth = 0);
        public abstract void Add(int componentHierarchyId);
        public abstract void Delete(int componentHierarchyId);

        public virtual string GetDepthSeparator(int depth, char sep = ' ')
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < depth; i++)
            {
                sb.Append(sep);
                sb.Append(sep);
                sb.Append(sep);
            }
                

            return sb.ToString();
        }
    }
}
