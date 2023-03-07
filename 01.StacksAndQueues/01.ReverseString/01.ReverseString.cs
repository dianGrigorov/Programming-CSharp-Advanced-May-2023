
string input = Console.ReadLine();
Stack<char> reverseString = new Stack<char>();
foreach (char ch in input)
{
    reverseString.Push(ch);
}

while (reverseString.Count > 0) 
{
    char ch = reverseString.Pop();
    Console.Write(ch);
}