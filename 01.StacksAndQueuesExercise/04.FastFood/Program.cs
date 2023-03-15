int foodQuantity = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int maxOrder = 0;

Queue<int> ordersQueue = new Queue<int>(orders);

while (ordersQueue.Count > 0)
{
    int currOrder = ordersQueue.Peek();
    if (currOrder > maxOrder)
    {
        maxOrder = currOrder;
    }
    if (foodQuantity >= currOrder)
    {
        ordersQueue.Dequeue();
        foodQuantity -= currOrder;
    }
    else
    {
        break;
    }
}
Console.WriteLine(maxOrder);
if (ordersQueue.Count > 0)
{
    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
}
else
{
    Console.WriteLine("Orders complete");
}