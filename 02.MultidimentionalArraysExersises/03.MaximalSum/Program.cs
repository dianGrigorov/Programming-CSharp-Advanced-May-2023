int[] dimentions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimentions[0];
int cols = dimentions[1];
int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] value = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = value[col];
    }
}

int maxSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;
for (int row = 0; row < rows - 2; row++)
{
       for (int col = 0; col < cols - 2; col++)
    {
        int currSum = 0;
        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
            {
                currSum += matrix[i, j];
            }
        }
        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");
for (int row = maxRow; row < maxRow + 3; row++)
{
    for (int col = maxCol; col < maxCol + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}
