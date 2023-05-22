int n = int.Parse(Console.ReadLine());
SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string token in tokens)
    {
        elements.Add(token);
    }
}

Console.WriteLine(string.Join(" ", elements));