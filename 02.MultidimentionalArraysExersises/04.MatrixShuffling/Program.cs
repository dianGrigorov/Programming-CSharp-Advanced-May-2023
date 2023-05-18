
int[] dimension = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = dimension[0];
int cols = dimension[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] valu = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = valu[col];
    }
}

string command;

while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] commArg = command.Split();
    
    if (IsCommandValid(commArg, matrix))
    {
        string tempValu = matrix[int.Parse(commArg[1]), int.Parse(commArg[2])];

        matrix[int.Parse(commArg[1]), int.Parse(commArg[2])] = 
            matrix[int.Parse(commArg[3]), int.Parse(commArg[4])];
        matrix[int.Parse(commArg[3]), int.Parse(commArg[4])] = tempValu;
        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}

static bool IsCommandValid(string[] commArg, string[,] matrix)
{
    return commArg.Length == 5
        &&commArg[0] == "swap"
        && int.Parse(commArg[1]) >= 0 && int.Parse(commArg[1]) < matrix.GetLength(0)
        && int.Parse(commArg[2]) >= 0 && int.Parse(commArg[2]) < matrix.GetLength(1)
        && int.Parse(commArg[3]) >= 0 && int.Parse(commArg[3]) < matrix.GetLength(0)
        && int.Parse(commArg[4]) >= 0 && int.Parse(commArg[4]) < matrix.GetLength(1);
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}