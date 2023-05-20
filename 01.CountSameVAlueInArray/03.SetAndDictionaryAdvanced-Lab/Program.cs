double[] numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> countValues = new Dictionary<double, int>();
for (int i = 0; i < numbers.Length; i++)
{
    if (!countValues.ContainsKey(numbers[i]))
    {
        countValues.Add(numbers[i], 0);
    }
    countValues[numbers[i]]++;
}
foreach (var item in countValues)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}