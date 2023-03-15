
int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
	int[] commands = Console.ReadLine()
		.Split()
		.Select(int.Parse)
		.ToArray();
	int curComm = commands[0];
	if (curComm == 1)
	{
		int num = commands[1];
		stack.Push(num);
	}
	if (curComm == 2)
	{
		if (stack.Count > 0)
		{
            stack.Pop();
        }
	}
	if (curComm == 3)
	{
        Console.WriteLine(stack.Max());
    }
	if (curComm == 4)
	{
        Console.WriteLine(stack.Min());
    }
}
Console.WriteLine(string.Join(", ", stack));