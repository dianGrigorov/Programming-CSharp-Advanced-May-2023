void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}



bool IsValidPosotion(char[,] matrix, int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0)
        && col >= 0 && col < matrix.GetLength(1);
}



Stack<int> stack = new Stack<int>(Console.ReadLine()
    .Split(" " , StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> queue = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));



int size = int.Parse(Console.ReadLine());

char[,] matrix = new char[size, size];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string tokens = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = tokens[col];
    }
}