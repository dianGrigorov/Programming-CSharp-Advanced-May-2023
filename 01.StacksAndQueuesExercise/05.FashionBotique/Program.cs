
int[] clothes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int capacity = int.Parse(Console.ReadLine());
Stack<int> clothesStack = new Stack<int>(clothes);
int racks = 1;
int currRack = capacity;
while (clothesStack.Count > 0)
{
    int currCloth = clothesStack.Peek();
    if (currRack - currCloth >= 0)
    {
        currRack -= currCloth;
        
        clothesStack.Pop();
    }
    else
    {
        currRack = capacity;
        racks++;
    }
}
Console.WriteLine(racks);