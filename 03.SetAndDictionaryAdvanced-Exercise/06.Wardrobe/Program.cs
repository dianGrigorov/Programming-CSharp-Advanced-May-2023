int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> clothesByColor = new();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);
    string color = tokens[0];
    string[] clothes = tokens.Skip(1).ToArray();

    if (!clothesByColor.ContainsKey(color))
    {
        clothesByColor.Add(color, new Dictionary<string, int>());
    }
    for (int j = 0; j < clothes.Length; j++)
    {
        if (!clothesByColor[color].ContainsKey(clothes[j]))
        {
            clothesByColor[color].Add(clothes[j], 0);
        }
        clothesByColor[color][clothes[j]]++;
    }
}

string[] findItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var color in clothesByColor)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var cloth in color.Value)
    {
        string printItem = $"* {cloth.Key} - {cloth.Value}";

        if (color.Key == findItem[0] && cloth.Key == findItem[1])
        {
            printItem += " (found!)" ;
        }
        Console.WriteLine(printItem);
    }
}