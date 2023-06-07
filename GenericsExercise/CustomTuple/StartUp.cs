

using CustomTuple;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] beerTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] bankTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


CustomTuple<string, string, string> person = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

CustomTuple<string, int, bool> beer = new(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");

CustomTuple<string, double, string> bank = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

Console.WriteLine(person);
Console.WriteLine(beer);
Console.WriteLine(bank);