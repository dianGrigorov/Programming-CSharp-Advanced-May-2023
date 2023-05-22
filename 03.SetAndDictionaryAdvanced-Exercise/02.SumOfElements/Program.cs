int[] lenghts = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < lenghts[0]; i++)
{
    int number = int.Parse(Console.ReadLine());
    firstSet.Add(number);
}
for (int i = 0; i < lenghts[1]; i++)
{
    int number = int.Parse(Console.ReadLine());
    secondSet.Add(number);
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(string.Join(" ", firstSet)); 


//first.UnionWith(second);
//first.IntersectWith(second);
//first.ExceptWith(second);
//second.ExceptWith(first);
//second.SymmetricExceptWith(first);
//first.SymmetricExceptWith(second);