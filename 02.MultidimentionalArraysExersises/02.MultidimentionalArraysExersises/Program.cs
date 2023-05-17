int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] values = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = values[col];
    }
}

int primaryDiagonal = 0;
int secondaryDiagonal = 0;
for (int row = 0; row < size; row++)
{
    primaryDiagonal += matrix[row, row];
    secondaryDiagonal += matrix[row, size - 1 -row];
}



Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));