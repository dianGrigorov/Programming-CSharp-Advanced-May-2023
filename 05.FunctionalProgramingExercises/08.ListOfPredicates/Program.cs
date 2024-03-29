﻿
int range = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

int[] numbers = Enumerable.Range(1, range).ToArray();

List<Predicate<int>> predicates = new();

foreach (int divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

foreach (var number in numbers)
{
    bool isDivisible = true;

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisible = false;
        }
    }
    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}