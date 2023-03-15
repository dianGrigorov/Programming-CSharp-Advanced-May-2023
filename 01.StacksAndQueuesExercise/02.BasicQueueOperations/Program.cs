
int[] comArg = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int numbersToDequeue = comArg[1];
int searchedNumber = comArg[2];
Queue<int> queue = new Queue<int>(numbers);

for (int i = 0; i < numbersToDequeue; i++)
{
    if (queue.Count > 0)
    {
        queue.Dequeue();
    }
}
if (queue.Contains(searchedNumber))
{
    Console.WriteLine("true");
}
else if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(queue.Min());
}

