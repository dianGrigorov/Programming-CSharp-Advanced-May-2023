int[] tokens = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int rows = tokens[0];
int cols = tokens[1];

int[,] matrix = new int[rows, cols];


for (int row = 0; row < rows; row++)
{
    int[] value = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = value[col];
    }
}

for (int col = 0; col < cols; col++)
{
    int columnsSum = 0;
    for (int row = 0; row < rows; row++)
    {
        columnsSum += matrix[row, col];
    }
    Console.WriteLine(columnsSum);
}