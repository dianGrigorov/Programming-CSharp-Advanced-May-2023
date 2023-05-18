int[] dimension = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string snake = Console.ReadLine();
int rows = dimension[0];
int cols = dimension[1];
char[,] matrix = new char[rows, cols];
int lenght = 0;

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = snake[lenght];
            lenght++;
            if (lenght == snake.Length)
            {
                lenght = 0;
            }
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = snake[lenght];
            lenght++;
            if (lenght == snake.Length)
            {
                lenght = 0;
            }
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}