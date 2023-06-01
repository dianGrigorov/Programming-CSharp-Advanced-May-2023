using System;
namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> peopleOver30 = new();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Person person = new Person(input[0], int.Parse(input[1]));

            if (person.Age > 30)
            {
                peopleOver30.Add(person);
            }
            
        }
        foreach (var person in peopleOver30.OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}
