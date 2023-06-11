

Dictionary<string, int> ducks = new Dictionary<string, int>();

ducks.Add("Darth Vader Ducky", 0);
ducks.Add("Thor Ducky", 0);
ducks.Add("Big Blue Rubber Ducky", 0);
ducks.Add("Small Yellow Rubber Ducky", 0);

Queue<int> time = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

Stack<int> numbersOfTask = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

while (time.Any())
{
    int programerTime = time.Dequeue();
    int curTask = numbersOfTask.Pop();
    int result = programerTime * curTask;
    if (result <= 60)
    {
        ducks["Darth Vader Ducky"]++;
    }
    else if (result <= 120)
    {
        ducks["Thor Ducky"]++;
    }
    else if (result <= 180)
    {
        ducks["Big Blue Rubber Ducky"]++;
    }
    else if (result <= 240)
    {
        ducks["Small Yellow Rubber Ducky"]++;
    }
    else
    {
        time.Enqueue(programerTime);
        numbersOfTask.Push(curTask - 2);
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

foreach (var duck in ducks)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}