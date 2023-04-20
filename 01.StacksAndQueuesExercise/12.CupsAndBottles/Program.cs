List<int> caps = new List<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse))
    .ToList();
Stack<int> bottles = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int wastedWater = 0;

while (caps.Any() && bottles.Any())
{
    int currBotle = bottles.Peek();

    if (currBotle >= caps[0])
    {
        wastedWater += bottles.Pop() - caps[0];
        caps.RemoveAt(0);
    }
    else
    {
        caps[0] -= bottles.Pop();

        if (caps[0] <= 0)
        {
            caps.RemoveAt(0);
        }
        
    }
}

if (caps.Any())
{
    Console.WriteLine($"Cups: {string.Join(" ", caps)}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
}
Console.WriteLine($"Wasted litters of water: {wastedWater}");