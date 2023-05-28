
Func<List<int>, List<int>> reverse = numbers =>
{
    List<int> result = new List<int>();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }
    return result;
};


Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, match) =>
{
    List<int> result = new List<int>();
    foreach (var number in numbers)
    {
        if (!match(number))
        {
            result.Add(number);
        }
    }
    return result;
};
List<int> numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

int divider = int.Parse(Console.ReadLine());
Predicate<int> checkDivider = n => n % divider == 0;

numbers = exclude(numbers, checkDivider);
numbers = reverse(numbers);

Console.WriteLine(string.Join(" ", numbers));