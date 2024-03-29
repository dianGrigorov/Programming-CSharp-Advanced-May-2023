﻿Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
string command;

while ((command = Console.ReadLine()) != "Revision")
{
    string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());

    }
    if (!shops[shop].ContainsKey(product))
    {
        shops[shop].Add(product, 0);
    }
    shops[shop][product] = price;
}

foreach (var shop in shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
{
   Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}