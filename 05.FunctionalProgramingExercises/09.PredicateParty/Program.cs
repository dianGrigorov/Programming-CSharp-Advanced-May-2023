
List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

string command;

while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value));
    }
    else if (action == "Double")
    {
        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

        foreach (var person in peopleToDouble)
        {
            int index = people.FindIndex(p => p == person);
            people.Insert(index, person);
        }
    }
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine($"Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    if (filter == "StartsWith")
    {
        return n => n.StartsWith(value);
    }
    if (filter == "EndsWith")
    {
        return n => n.EndsWith(value);
    }
    if (filter == "Length")
    {
        return n => n.Length == int.Parse(value);
    }

    return default;
}