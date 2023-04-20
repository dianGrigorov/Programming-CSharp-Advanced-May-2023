int[] tokens = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = tokens[0];
int cols = tokens[1];

int[,] matrix = new int[rows, cols];
int sum = 0;
for (int row = 0; row < rows; row++)
{
    int[] value = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = value[col];
        sum += matrix[row, col];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);