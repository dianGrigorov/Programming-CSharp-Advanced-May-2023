
Action<string[], Predicate<string>> print = (names, match) =>
{
    foreach (var name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};

int lenght = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Predicate<string> matchLenght = n => n.Length <= lenght;
print(names, matchLenght);
//print(names, n => n.Length <= lenght);