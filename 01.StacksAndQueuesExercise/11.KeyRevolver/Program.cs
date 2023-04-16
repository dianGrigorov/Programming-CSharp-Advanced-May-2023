int bulletPrice = int.Parse(Console.ReadLine());
int barrelSize  = int.Parse(Console.ReadLine());
Stack<int> bullets = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> locks = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));
int intelligence = int.Parse(Console.ReadLine());

int initialBulets = bullets.Count;
int currentBarrelSize = barrelSize;

while (bullets.Any())
{
    currentBarrelSize--;
    if (bullets.Pop() <= locks.Peek())
    {
        intelligence -= bulletPrice;
        locks.Dequeue();
        Console.WriteLine("Bang!");
    }
    else
    {
        intelligence -= bulletPrice;
        Console.WriteLine("Ping!");
    }
    if (currentBarrelSize == 0 && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        currentBarrelSize = barrelSize;
    }
    if (!locks.Any())
    {
        Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");

        return;
    }
}

Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");