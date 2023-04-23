int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
int primarySum = 0;
int secondarySum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] value = Console.ReadLine().Split()
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = value[col];
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    primarySum += matrix[row, row];
    secondarySum += matrix[row, matrix.GetLength(0) - 1 - row];
}
Console.WriteLine(Math.Abs(primarySum - secondarySum));