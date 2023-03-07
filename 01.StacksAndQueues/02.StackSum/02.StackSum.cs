
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>();
int sum = 0;
foreach (int i in input)
{
    stack.Push(i);
}
string comm;
while ((comm = Console.ReadLine().ToLower()) != "end")
{
    string[] splitedCommand = comm.Split();
    string currComm = splitedCommand[0];

    if (currComm == "add")
    {
        int firstNum = int.Parse(splitedCommand[1]);
        int secondNum = int.Parse(splitedCommand[2]);
        stack.Push(firstNum);
        stack.Push(secondNum);
    }
    if (currComm == "remove")
    {
        int n = int.Parse(splitedCommand[1]);
        if (stack.Count >= n)
        {
            while(n > 0)
            {
                stack.Pop();
                n--;
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");