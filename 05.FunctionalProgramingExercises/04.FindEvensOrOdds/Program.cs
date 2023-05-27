Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> range = new List<int>();

    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;
};

Func<string, int, bool> evenOddMatch = (condition, number) =>
{
    if (condition == "even")
    {
        return number % 2 == 0;
    }
    else
    {
        return number % 2 != 0;
    }
};

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

List<int> numbers = generateRange(range[0], range[1]);


foreach (var number in numbers)
{
    if (evenOddMatch(command, number))
    {
        Console.Write($"{number} ");
    }
}