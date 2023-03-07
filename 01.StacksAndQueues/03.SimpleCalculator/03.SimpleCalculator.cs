
string[] input = Console.ReadLine()
    .Split()
    .Reverse()
    .ToArray();
int result = 0;
Stack<int> num = new Stack<int>();
Stack<string> operations = new Stack<string>();
foreach (string number in input)
{

    if (number == "+" || number == "-")
    {
        operations.Push(number);
    }
    else
    {
        num.Push(int.Parse(number));
    }

}
result += num.Pop();

while (num.Count != 0)

{
    string oper = operations.Pop();
    if (oper == "+")
    {
        result += num.Pop();
    }
    else if (oper == "-")
    {
        result -= num.Pop();
    }
}
Console.WriteLine(result);


