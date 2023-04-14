string parentheses = Console.ReadLine();
Stack<char> stack = new Stack<char>();
string output = string.Empty;


foreach (char item in parentheses)
{
   if (item ==  '(' || item == '[' || item == '{')
    {
        stack.Push(item);
    }
    else
    {
        if (stack.Count == 0)
        {
            output = "NO";
            return;
        }
        else
        {
            char currChar = stack.Peek();
            if ((currChar == '(' && item == ')')||
                (currChar == '[' && item == ']')||
                (currChar == '{' && item == '}'))
            {
                stack.Pop();
                output = "YES";
            }
            else
            {
                output = "NO";
                break;
            }
        }
    }
}
if (stack.Count > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine(output);
}



