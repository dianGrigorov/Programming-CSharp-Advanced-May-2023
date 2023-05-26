//Predicate<string> checker = n => n[0] == n.ToUpper()[0];

List<string> tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(w => w[0] == w.ToUpper()[0])
    .ToList();

tokens.ForEach(w =>  Console.WriteLine(w));
