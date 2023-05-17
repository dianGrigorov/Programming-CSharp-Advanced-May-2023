int[] dimension = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimension[0];
int cols = dimension[1];
char[,] matrix = new char[rows, cols];

int countSubMatrix = 0;

for (int row = 0; row < rows; row++)
{
    char[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = tokens[col];
    }
}

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] 
            && matrix[row, col] == matrix[row + 1, col]
            && matrix[row, col] == matrix[row + 1, col + 1])
        {
            countSubMatrix++;
        }
    }
}
Console.WriteLine(countSubMatrix);