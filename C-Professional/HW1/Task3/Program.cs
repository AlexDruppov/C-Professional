using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyTree root = new FamilyTree("John", 1950);
            FamilyTree child1 = new FamilyTree("Michael", 1975);
            FamilyTree child2 = new FamilyTree("Anna", 1980);
            FamilyTree grandchild1 = new FamilyTree("Sarah", 2005);
            FamilyTree grandchild2 = new FamilyTree("Tom", 2010);

            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(grandchild1);
            child2.AddChild(grandchild2);

            Console.WriteLine("Descendants of John:");
            foreach (var box in root.GetDescendants())
            {
                Console.WriteLine($"{box.Name}, {box.Year}");
            }

            int searchYear = 2010;
            Console.WriteLine($"\nRelatives born in {searchYear}:");
            foreach (var box in root.GetDescendantsByYear(searchYear))
            {
                Console.WriteLine($"{box.Name}, {box.Year}");
            }

            Console.ReadKey();
        }
    }
}
