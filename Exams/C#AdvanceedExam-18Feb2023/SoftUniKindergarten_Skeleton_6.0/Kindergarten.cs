using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }


        public bool AddChild(Child child)
        {
            if (Capacity > Registry.Count)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }

        public bool RemoveChild(string childFulName)
        {
            Child childToRemove = Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFulName);
            if (childToRemove != null)
            {
                return Registry.Remove(childToRemove);
            }
            return false;
        }

        public int ChildrenCount()
        {
            int count = Registry.Count;
            return count;
        }

        public Child GetChild(string childFulName)
        {

            Child getChild = Registry.FirstOrDefault(c => $"{c.FirstName} {c.LastName}" == childFulName);

            return getChild;

        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {Name}:");

            foreach (Child child in Registry.OrderByDescending(ch => ch.Age).ThenBy(ch => ch.LastName).ThenBy(ch => ch.FirstName))
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
