int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    jaggedArray[row] = tokens;
}

for (int row = 0; row < jaggedArray.Length - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;
            
        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;
        }
    }
   
}

string command;

while ((command = Console.ReadLine()) != "End")
{
    string[] commArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int row = int.Parse(commArg[1]);
    int col = int.Parse(commArg[2]);
    int value = int.Parse(commArg[3]);
    if (ValidCell(row, col, jaggedArray))
    {
        if (commArg[0] == "Add")
        {
            jaggedArray[row][col] += value;
        }
        if (commArg[0] == "Subtract")
        {
            jaggedArray[row][col] -= value;
        }
    }
}

foreach (var row in jaggedArray)
{
    Console.WriteLine(string.Join(" ", row));
}

static bool ValidCell(int row, int col, int[][] jagedArray)
{
    return
          row >= 0 && row < jagedArray.Length
       && col >= 0 && col < jagedArray[row].Length;
}