int n = int.Parse(Console.ReadLine());
Dictionary<string, List<double>> averageGrades = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = tokens[0];
    double grade = double.Parse(tokens[1]);

    if (!averageGrades.ContainsKey(name))
    {
        averageGrades.Add(name, new List<double>());
    }
    averageGrades[name].Add(grade);
}
foreach (var student in averageGrades)
{
    Console.Write($"{student.Key} -> ");

    foreach (var grades in student.Value)
    {
        Console.Write($"{grades:f2} ");
       
    }
    Console.WriteLine($"(avr: {student.Value.Average():f2})");


}