int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = tokens[col];
    }
}
string[] cordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < cordinates.Length; i++)
{
    int[] currCordinates = cordinates[i]
        .Split(",")
        .Select(int.Parse)
        .ToArray();
    int row = currCordinates[0];
    int col = currCordinates[1];

    Explode(row, col, size, matrix);
   
}
int aliveCells = 0;
int sum = 0;
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row,col] > 0)
        {
            aliveCells++;
            sum += matrix[row,col];
        }
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");

PrintMatrix(size, matrix);

void Explode(int row, int col, int size, int[,] matrix)
{
    int value = matrix[row, col];

    if (value > 0)
    {
        matrix[row, col] = 0;
        //top
        if (row > 0 && matrix[row - 1, col] > 0)
        {
            matrix[row - 1, col] -= value;
        }
        //top left
        if (row > 0 && col > 0 && matrix[row - 1, col - 1] > 0)
        {
            matrix[row - 1, col - 1] -= value;
        }
        // top right
        if (row > 0 && col + 1 < size && matrix[row - 1, col + 1] > 0)
        {
            matrix[row - 1, col + 1] -= value;
        }
        // left
        if (col > 0 && matrix[row, col - 1] > 0)
        {
            matrix[row, col - 1] -= value;
        }
        // right
        if (col + 1 < size && matrix[row, col + 1] > 0)
        {
            matrix[row, col + 1] -= value;
        }
        //bottom
        if (row + 1 < size && matrix[row + 1, col] > 0)
        {
            matrix[row + 1, col] -= value;
        }
        
        //bottom left
        if (row + 1 < size && col  > 0 && matrix[row + 1, col - 1] > 0)
        {
            matrix[row + 1, col - 1] -= value;
        }
        //bottom right
        if (row + 1 < size && col + 1 < size && matrix[row + 1, col + 1] > 0)
        {
            matrix[row + 1, col + 1] -= value;
        }
    }
}

static void PrintMatrix(int size, int[,] matrix)
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}