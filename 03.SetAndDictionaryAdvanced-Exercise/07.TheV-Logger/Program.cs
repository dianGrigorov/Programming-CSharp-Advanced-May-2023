string command;
Dictionary<string, Dictionary<string, HashSet<string>>> vlogers = new();

while ((command = Console.ReadLine()) != "Statistics")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (tokens[1] == "joined")
    {
        string vlogerName = tokens[0];

        if (!vlogers.ContainsKey(vlogerName))
        {
            vlogers.Add(vlogerName, new Dictionary<string, HashSet<string>>());
            vlogers[vlogerName].Add("followers", new HashSet<string>());
            vlogers[vlogerName].Add("following", new HashSet<string>());
        }
    }
    else if (tokens[1] == "followed")
    {
        string vloger = tokens[0];
        string vlogerToFolow = tokens[2];
        if (vlogers.ContainsKey(vloger) 
            && vlogers.ContainsKey(vlogerToFolow)
            && vloger != vlogerToFolow)
        {
            vlogers[vloger]["following"].Add(vlogerToFolow);
            vlogers[vlogerToFolow]["followers"].Add(vloger);
        }
    }
}

Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
int count = 1;

Dictionary<string, Dictionary<string, HashSet<string>>> sortedVlogers = vlogers
    .OrderByDescending(x => x.Value["followers"].Count)
    .ThenBy(x => x.Value["following"].Count)
    .ToDictionary(x => x.Key, x => x.Value);

foreach (var vloger in sortedVlogers)
{
    Console.WriteLine($"{count}. {vloger.Key} : {vloger.Value["followers"].Count} followers, {vloger.Value["following"].Count} following");
   
    if (count == 1)
    {
        foreach (var follower in vloger.Value["followers"].OrderBy(x => x))
        {
            Console.WriteLine($"*  {follower}");
        }
    }
   
    count++;
}