using System;

namespace ClothesMagazine
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Initialize the repository (Magazine)
            Magazine magazine = new Magazine("Zara", 2);

            //Initialize entity (Cloth)
            Cloth cloth1 = new Cloth("red", 36, "dress");

            Cloth cloth2 = new Cloth("brown", 34, "t-shirt"); 
            Cloth cloth3 = new Cloth("blue", 32, "jeans");
            magazine.AddCloth(cloth2);
            magazine.AddCloth(cloth3);
            magazine.AddCloth(cloth1);

            Console.WriteLine(magazine.Report());
            int n = magazine.GetClothCount();
            Console.WriteLine(n);
        }
    }
}
