int size = int.Parse(Console.ReadLine());

char[,] field = new char[size, size];
int startRow = 0;
int startCol = 0;
int battleCruisers = 0;
int bombs = 0;
for (int row = 0; row < size; row++)
{
    string tokens = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        field[row, col] = tokens[col];
        if (field[row, col] == 'S')
        {
            field[row, col] = '-';
            startRow = row;
            startCol = col;
        }
    }
}

string command = Console.ReadLine();

while (true)
{
    if (command == "up")
    {
        Move(field, -1, 0, ref startRow, ref startCol, ref battleCruisers, ref bombs);
    }
    else if (command == "down")
    {
        Move(field, 1, 0, ref startRow, ref startCol, ref battleCruisers, ref bombs);
    }

    else if (command == "right")
    {
        Move(field, 0, 1, ref startRow, ref startCol, ref battleCruisers, ref bombs);
    }
    else if (command == "left")
    {
        Move(field, 0, -1, ref startRow, ref startCol, ref battleCruisers, ref bombs);
    }

    command = Console.ReadLine();
}

static void Move(char[,] field, int nextRow, int nextCol, ref int startRow, ref int startCol, ref int battleCruisers, ref int bombs)
{
    if (field[startRow + nextRow, startCol + nextCol] == 'C')
    {
        
        field[startRow + nextRow, startCol + nextCol] = '-';
        battleCruisers++;
        startRow += nextRow;
        startCol += nextCol;
        
        if (battleCruisers == 3)
        {
            field[startRow, startCol] = 'S';
            Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

            PrintMatrix(field);
            Environment.Exit(0);
        }
    }
    else if (field[startRow + nextRow, startCol + nextCol] == '*')
    {
      
        field[startRow + nextRow, startCol + nextCol] = '-';
        bombs++;
        startRow += nextRow;
        startCol += nextCol;
       
        if (bombs == 3)
        {
            field[startRow, startCol] = 'S';
            Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{startRow}, {startCol}]!");

            PrintMatrix(field);
            Environment.Exit(0);
        }
    }
    else
    {
        field[startRow, startCol] = '-';
        startRow += nextRow;
        startCol += nextCol;
    }

}

static void PrintMatrix(char[,] matrix)
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