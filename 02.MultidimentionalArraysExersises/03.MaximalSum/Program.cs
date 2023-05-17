int[] demension = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = demension[0];
int cols = demension[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] tokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = tokens[col];
    }
}

int maxSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int curSum = 0;
        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
            {
                curSum += matrix[i, j];
            }
        }
        if (curSum > maxSum)
        {
            maxSum = curSum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"sum = {maxSum}");
for (int row = maxRow; row < maxRow + 3; row++)
{
    for (int col = maxCol; col < maxCol + 3; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}