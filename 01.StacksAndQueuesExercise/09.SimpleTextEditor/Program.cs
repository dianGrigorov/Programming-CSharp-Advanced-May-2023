using System.Text;

int n = int.Parse(Console.ReadLine());
string text = string.Empty;
Stack<string> stack = new Stack<string>();

for (int i = 0; i < n; i++)
{
    string[] commandArg = Console.ReadLine().Split();
    int command = int.Parse(commandArg[0]);
	switch (command)
	{
		case 1:
            stack.Push(text);
            string newText = commandArg[1];
            text += newText;
			break;
        case 2:
            stack.Push(text);
            int erasedElements = int.Parse(commandArg[1]);
            text = text.Remove(text.Length - erasedElements, erasedElements);
            break;
        case 3:
            int index = int.Parse(commandArg[1]) - 1;
            Console.WriteLine(text[index]);
            break;
        case 4:
            text = stack.Pop();
            break;
    }
}