double[] tokens = Console.ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .ToArray();

tokens = tokens.Select(x => x * 1.2).ToArray();
//tokens.ToList().ForEach(x => Console.WriteLine($"{x *= 1.2:f2}"));
foreach (var token in tokens)
{
    Console.WriteLine(token);
}
