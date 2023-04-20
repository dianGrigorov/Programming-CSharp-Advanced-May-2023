int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
int diagonalSum = 0;

for (int row = 0; row < size; row++)
{
    int[] value = Console.ReadLine().Split(' ')
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = value[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    diagonalSum += matrix[row, row];
}
Console.WriteLine(diagonalSum);