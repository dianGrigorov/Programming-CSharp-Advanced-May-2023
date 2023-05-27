Action<string, string[]> printWithTitle = (title, names) =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};
string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

printWithTitle("Sir", names);