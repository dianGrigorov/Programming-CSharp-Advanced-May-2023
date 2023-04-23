int[] dimentions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = dimentions[0];
int cols = dimentions[1];
string snake = Console.ReadLine();

char[,] isle = new char[rows, cols];
int initialIndex = 0;
for (int row = 0; row < rows; row++)
{
    if (row % 2 ==0 )
    {
        for (int col = 0; col < cols; col++)
        {
            isle[row, col] = snake[initialIndex];
            initialIndex++;
            if (initialIndex >= snake.Length)
            {
                initialIndex = 0;
            }
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            isle[row, col] = snake[initialIndex];
            initialIndex++;
            if (initialIndex >= snake.Length)
            {
                initialIndex = 0;
            }
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(isle[row, col] + " ");
    }
    Console.WriteLine();
}