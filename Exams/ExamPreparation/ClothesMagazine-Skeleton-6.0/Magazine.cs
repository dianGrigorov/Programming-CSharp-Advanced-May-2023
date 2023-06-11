using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }

        }
        public bool RemoveCloth(string color)
        {
            Cloth clothToRemove = Clothes.FirstOrDefault(c => c.Color == color);
            if (clothToRemove != null)
            {
                return Clothes.Remove(clothToRemove);

            }
            return false;

            //for (int i = 0; i < Clothes.Count; i++)
            //{
            //    if (Clothes[i].Color == color)
            //    {
            //        Clothes.RemoveAt(i);
            //        return true;
            //    }
            //}
            //return false;

        }
        public Cloth GetSmallestCloth()
        {
            Cloth smallestCloth = Clothes[0];

            foreach (var cloth in Clothes)
            {

                if (cloth.Size < smallestCloth.Size)
                {
                    smallestCloth = cloth;
                }
            }
            return smallestCloth;
        }
        public Cloth GetCloth(string color)
        {
            Cloth clothBycolor = Clothes.FirstOrDefault(c => c.Color == color);
            return clothBycolor;
        }
        public int GetClothCount()
        {
            int countClothes = Clothes.Count;
            return countClothes;
        }
        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(c => c.Size))
            {
                result.AppendLine(cloth.ToString());
            }
            return result.ToString().Trim();
        }
    }
}
