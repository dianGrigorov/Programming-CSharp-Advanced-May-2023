string input = Console.ReadLine();
Stack<int> index = new Stack<int>();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        index.Push(i);
    }
    if (input[i] == ')')
    {
        for (int j = index.Pop(); j <= i; j++)
        {
            Console.Write(input[j]);
        }
        Console.WriteLine();
    }
}