Queue<int> textiles = new(Console.ReadLine().Split().Select(int.Parse));
Stack<int> medicaments = new(Console.ReadLine().Split().Select(int.Parse));

Dictionary<string, int> healingItems = new();
healingItems.Add("Patch", 0);
healingItems.Add("Bandage", 0);
healingItems.Add("MedKit", 0);


while (textiles.Any() && medicaments.Any())
{
    int curTextile = textiles.Dequeue();
    int curMed = medicaments.Pop();
    int result = curTextile + curMed;

    if (result == 30)
    {
        healingItems["Patch"]++;
    }
    else if (result == 40)
    {
        healingItems["Bandage"]++;
    }
    else if (result == 100)
    {
        healingItems["MedKit"]++;
    }
    else if (result > 100)
    {
        healingItems["MedKit"]++;
        result -= 100;
        medicaments.Push(medicaments.Pop() + result);
    }
    else
    {
        medicaments.Push(curMed + 10);
    }
}

if (textiles.Count == 0 && medicaments.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}


else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}
else
{
    Console.WriteLine("Textiles are empty.");
}

foreach (var item in healingItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
{
    if (item.Value > 0)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}
if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
