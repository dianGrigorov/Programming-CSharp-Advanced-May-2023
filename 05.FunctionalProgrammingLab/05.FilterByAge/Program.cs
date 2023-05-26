using System;
using System.Diagnostics.Contracts;

int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
   
    people.Add(new Person()
    {
        Name = input[0],
        Age = int.Parse(input[1]),
    });

}

string filterType = Console.ReadLine();
int filterAge = int.Parse(Console.ReadLine());
string formatType = Console.ReadLine();

Func<Person, bool> filter = GetFilter(filterType, filterAge);

people = people.Where(filter).ToList();

Action<Person> printer = GetPrinter(formatType);

foreach (var person in people)
{
    printer(person);
}
Func<Person, bool> GetFilter(string filterType, int filterAge)
{
    switch (filterType)
    {
        case "older": return person => person.Age >= filterAge;
        case "younger": return person => person.Age < filterAge;
        default:
            return null;
    }
}

Action<Person> GetPrinter(string formatType)
{
    switch (formatType)
    {
        case "name age": return p => Console.WriteLine($"{p.Name} - {p.Age}");
        case "name": return p => Console.WriteLine(p.Name);
        case "age": return p => Console.WriteLine(p.Age);

        default:
            return null;
    }

}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}
