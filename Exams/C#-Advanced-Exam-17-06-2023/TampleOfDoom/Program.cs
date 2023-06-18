Queue<int> tools = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Stack<int> substances = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

List<int> challenges = new List<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

while (tools.Any() && substances.Any())
{
    int currTool = tools.Dequeue();
    int currSubstance = substances.Pop();
    int result = currTool * currSubstance;
    bool found = false;
    if (challenges.Count > 0)
    {
        for (int i = 0; i < challenges.Count; i++)
        {
            if (result == challenges[i])
            {
                challenges.Remove(result);
                found = true;
                break;
            }
        }
    }
    if (!found)
    {
        currTool++;
        tools.Enqueue(currTool);
        currSubstance--;
        if (!(currSubstance == 0))
        {
            substances.Push(currSubstance);
        }
    }
    
    if (challenges.Count == 0)
    {
        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        break;
    }
    if (!tools.Any() || !substances.Any())
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }
}

if (tools.Any())
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}
if (substances.Any())
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
if (challenges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}