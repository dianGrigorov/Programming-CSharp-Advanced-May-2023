using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items = new();
        public void Add(T value)
        {
            items.Add(value);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            (items[firstIndex], items[secondIndex]) = (items[secondIndex], items[firstIndex]);
        }

        public int Count(T itemToCompare)
        {
            int count = 0;
            foreach (T item in items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().Trim();

        }
    }
}
