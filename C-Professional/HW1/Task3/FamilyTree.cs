using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class FamilyTree
    {
        public string Name { get; set; }
        public int Year {  get; set; }
        public List<FamilyTree> Children { get; set; }

        public FamilyTree(string name, int year) 
        {
            Name = name;
            Year = year;
            Children = new List<FamilyTree>();
        }

        public void AddChild(FamilyTree child)
        {
            Children.Add(child);
        }

        public void RemoveChild(FamilyTree child)
        {
            Children.Remove(child);
        }

        public List<FamilyTree> GetDescendants()
        {
            var descendants = new List<FamilyTree>();
            foreach (var child in Children)
            {
                descendants.Add(child);
                descendants.AddRange(child.GetDescendants());
            }
            return descendants;
        }

        public List<FamilyTree> GetDescendantsByYear(int year)
        {
            var descendants = new List<FamilyTree>();
            if (Year == year)
            {
                descendants.Add(this);
            }
            foreach (var child in Children)
            {
                descendants.AddRange(child.GetDescendantsByYear(year));
            }
            return descendants;
        }
    }
}
