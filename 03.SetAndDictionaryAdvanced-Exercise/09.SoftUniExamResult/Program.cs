Dictionary<string, int> usersPoints = new Dictionary<string, int>();
Dictionary<string, int> languageSubmitssions = new Dictionary<string, int>();
string command;

while ((command = Console.ReadLine()) != "exam finished")
{
    string[] tokens = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];
    if (tokens[1] == "banned")
    {
        usersPoints.Remove(name);
        continue;
    }

    string language = tokens[1];
    int points = int.Parse(tokens[2]);

    if (!usersPoints.ContainsKey(name))
    {
        usersPoints.Add(name, 0);
    }
    if (usersPoints[name] < points)
    {
        usersPoints[name] = points;
    }
    if (!languageSubmitssions.ContainsKey(language))
    {
        languageSubmitssions.Add(language, 0);
    }
    languageSubmitssions[language]++;
}

Console.WriteLine("Results:");
foreach (var user in usersPoints.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
{
    Console.WriteLine($"{user.Key} | {user.Value}");
}
Console.WriteLine("Submissions:");
foreach (var language in languageSubmitssions.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
{
    Console.WriteLine($"{language.Key} - {language.Value}");
}