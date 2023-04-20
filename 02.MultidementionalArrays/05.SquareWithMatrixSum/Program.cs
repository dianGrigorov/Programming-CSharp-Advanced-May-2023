int[] tokens = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int rows = tokens[0];
int cols = tokens[1];

int[,] matrix = new int[rows, cols];

int maxSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < rows; row++)
{
    int[] values = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}

for (int row = 0; row < rows - 1 ; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int currSum = matrix[row, col] + matrix[row, col + 1]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1];
        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxRow = row;
            maxCol = col;
        }
    } 
}

for (int row = maxRow; row <= maxRow + 1; row++)
{
    for (int col = maxCol; col <= maxCol + 1; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(maxSum);