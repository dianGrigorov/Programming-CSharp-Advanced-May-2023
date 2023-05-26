double[] tokens = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .Select(x => x *=1.2)
    .ToArray();

tokens.ToList().ForEach(x => Console.WriteLine($"{x:f2}"));

