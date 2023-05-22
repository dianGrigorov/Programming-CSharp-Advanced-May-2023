string input = Console.ReadLine();

Dictionary<char, int> symbols = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char currChar = input[i];

    if (!symbols.ContainsKey(currChar))
    {
        symbols.Add(currChar, 0);
    }
    symbols[currChar]++;
}


foreach (var ch in symbols.OrderBy(x => x.Key))
{
    Console.WriteLine($"{ch.Key}: {ch.Value} times/s");
}