int[] numbers = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(n  => n % 2 == 0)
    .OrderBy(n => n)
    .ToArray();

string result = string.Join(", ", numbers);
Console.WriteLine(result);
