string command;

Dictionary<string, string> contentInfo = new();
Dictionary<string, Dictionary<string, int>> usersInfo = new();
while ((command = Console.ReadLine()) != "end of contests")
{
    string[] tokens = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

    string content = tokens[0];
    string password = tokens[1];
    if (!contentInfo.ContainsKey(content))
    {
        contentInfo.Add(content, password);
    }
}

command = Console.ReadLine();

while ((command != "end of submissions"))
{
    string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
    string content = tokens[0];
    string password = tokens[1];
    string user = tokens[2];
    int points = int.Parse(tokens[3]);

    if (contentInfo.ContainsKey(content))
    {
        if (contentInfo[content] == password)
        {
            if (!usersInfo.ContainsKey(user))
            {
                usersInfo.Add(user, new Dictionary<string, int>());
                
            }
            if (!usersInfo[user].ContainsKey(content))
            {
                usersInfo[user].Add(content, points);
            }
            
            if (points > usersInfo[user][content])
            {
                usersInfo[user][content] = points;
            }

        }
    }

    command = Console.ReadLine();
}

int bestScore = 0;
string bestUser = string.Empty;
foreach (var user in usersInfo)
{
    int currScore = 0;
    foreach (var points in user.Value)
    {
        currScore += points.Value;
    }
    if (bestScore < currScore)
    {
        bestScore = currScore;
        bestUser = user.Key;
    }
}

Console.WriteLine($"Best candidate is {bestUser} with total {bestScore} points.");
Console.WriteLine("Ranking: ");
foreach (var user in usersInfo.OrderBy(x => x.Key))
{
    Console.WriteLine(user.Key);
    foreach (var (content,points) in user.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {content} -> {points}");
    }
}
