using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> white = new(Console.ReadLine()
      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
      .Select(int.Parse));
            Queue<int> grey = new(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<string, int> locations = new()
{
    { "Sink", 0},
    { "Oven", 0},
    { "Countertop", 0},
    { "Wall", 0},
    { "Floor", 0},
};

            while (grey.Any() && white.Any())
            {
                int currWhite = white.Peek();
                int currGrey = grey.Peek();

                if (currGrey == currWhite)
                {
                    int sum = currGrey + currWhite;
                    if (sum == 40)
                    {
                        locations["Sink"]++;
                    }
                    else if (sum == 50)
                    {
                        locations["Oven"]++;
                    }
                    else if (sum == 60)
                    {
                        locations["Countertop"]++;
                    }
                    else if (sum == 70)
                    {
                        locations["Wall"]++;
                    }
                    else
                    {
                        locations["Floor"]++;
                    }
                    white.Pop();
                    grey.Dequeue();
                }
                else
                {
                    white.Push(white.Pop() / 2);
                    grey.Enqueue(grey.Dequeue());
                }
            }
            string whiteTilesLeft = white.Count == 0 ? "none" : string.Join(", ", white);
            string greyTilesLeft = grey.Count == 0 ? "none" : string.Join(", ", grey);

            Console.WriteLine($"White tiles left: {whiteTilesLeft}");
            Console.WriteLine($"Grey tiles left: {greyTilesLeft}");

            foreach (var item in locations.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Where(x => x.Value > 0))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
