
int[] ints = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int n = ints[0];
int popedElement = ints[1];
int containElement = ints[2];

int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    stack.Push(elements[i]);
}

for (int i = 0; i < popedElement; i++)
{
    if (stack.Count > 0)
    {
        stack.Pop();
    }
   
}

if (stack.Contains(containElement))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine(stack.Min()); 
}