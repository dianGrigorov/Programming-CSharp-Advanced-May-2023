int numOfPumps = int.Parse(Console.ReadLine());
Queue<int[]> pumpsInfo = new Queue<int[]>();

for (int i = 0; i < numOfPumps; i++)
{
    int[] token = Console.ReadLine().
        Split().
        Select(int.Parse).
        ToArray();
    pumpsInfo.Enqueue(token);
}

int index = -1;
while (true)
{
    int fuel = 0;
    bool valid = true;
    index++;

    for (int i = 0; i < pumpsInfo.Count; i++)
    {
        int[] currPump = pumpsInfo.Dequeue();
        int currFuel = currPump[0];
        int currDistance = currPump[1];
        fuel += currFuel;
        fuel -= currDistance;

        pumpsInfo.Enqueue(currPump);

        if (fuel < 0)
        {
            valid = false;
         
        }

    }
    if (valid)
    {
        Console.WriteLine(index);
        break;
    }
    if (index >= pumpsInfo.Count)
    {
        break;
    }

    pumpsInfo.Enqueue(pumpsInfo.Dequeue());
    
}

