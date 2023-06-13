Queue<int> coffee = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> milk = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> drinks = new()
{
    { "Cortado", 0},
    { "Espresso", 0},
    { "Capuccino", 0 },
    { "Americano", 0},
    { "Latte", 0}
};

while(coffee.Count > 0 && milk.Count > 0)
{
    int currCoffee = coffee.Dequeue();
    int currMilk = milk.Pop();
    int result = currCoffee + currMilk;
    if (result == 50)
    {
        drinks["Cortado"]++;
    }
    else if(result == 75)
    {
        drinks["Espresso"]++;
    }
    else if (result == 100)
    {
        drinks["Capuccino"]++;
    }
    else if (result == 150)
    {
        drinks["Americano"]++;
    }
    else if (result == 200)
    {
        drinks["Latte"]++;
    }
    else
    {
        milk.Push(currMilk - 5);
    }
}

if (coffee.Count == 0 && milk.Count == 0)
{
   
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");

}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}
if (coffee.Count > 0)
{
    Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
}
else
{
    Console.WriteLine("Coffee left: none");
}
if (milk.Count > 0)
{
    Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
}
else
{
    Console.WriteLine("Milk left: none");
}
foreach (var drink in drinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key).Where(x => x.Value > 0))
{
    Console.WriteLine($"{drink.Key}: {drink.Value}");
}