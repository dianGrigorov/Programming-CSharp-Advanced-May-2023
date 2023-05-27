Action<string[]> print = name =>
{
    Console.WriteLine(string.Join(Environment.NewLine, name));

};

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
print(names);