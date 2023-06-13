using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }

        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public List<Shoe> Shoes  { get; set; }
        public int Count => Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (StorageCapacity > Shoes.Count)
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            return "No more space in the storage room.";
        }

        public int RemoveShoes(string material)
        {
            int count = 0;
            for (int i = 0; i < Shoes.Count; i++)
            {
                if (Shoes[i].Material == material)
                {
                    Shoes.Remove(Shoes[i]);
                    i = -1;
                    count++;
                }
            }
            return count;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> shoes = new List<Shoe>();
            foreach (var shoe in Shoes)
            {
                if (shoe.Type == type.ToLower())
                {
                    shoes.Add(shoe);
                }
            }
            return shoes;
        }
        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.FirstOrDefault(sh => sh.Size == size);
            return shoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();

            if (Shoes.Any(sh => sh.Size == size && sh.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (var shoe in Shoes)
                {
                    if (shoe.Size == size && shoe.Type == type)
                    {
                        sb.AppendLine(shoe.ToString());
                    }
                }
            }
            else
            {
                sb.AppendLine("No matches found!");
            }

           return sb.ToString().Trim();
        }
    }
}
