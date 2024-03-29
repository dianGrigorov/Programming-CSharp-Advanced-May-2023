﻿int n = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
	if (!numbers.ContainsKey(num))
	{
		numbers.Add(num, 0);
	}
	numbers[num]++;
}
foreach (var num in numbers.Where(x => x.Value % 2 == 0))
{
    Console.WriteLine(num.Key);
}