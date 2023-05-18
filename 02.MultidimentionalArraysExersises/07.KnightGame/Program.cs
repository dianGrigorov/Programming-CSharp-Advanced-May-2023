int size = int.Parse(Console.ReadLine());

char[,] board = new char[size, size];

for (int row = 0; row < size; row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        board[row, col] = input[col];
    }
}

int removedKnights = 0;

while (true)
{
    int mostAttacked = 0;
    int rowMostAttacked = 0;
    int colMostAtacked = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (board[row, col] == 'K')
            {
                int currAttacker = CountAttackedKnights(row, col, size, board);

                if (mostAttacked < currAttacker)
                {
                    mostAttacked = currAttacker;
                    rowMostAttacked = row;
                    colMostAtacked = col;
                }
            }

        }
    }
    if (mostAttacked == 0)
    {
        break;
    }
    else
    {
        board[rowMostAttacked, colMostAtacked] = '0';
        removedKnights++;
    }
}
Console.WriteLine(removedKnights);

static int CountAttackedKnights(int row, int col, int size, char[,] board)
{
    int attackedKnight = 0;
    // 2 up 1 left
    if (ValidateCell(row - 2, col - 1, size))
    {
        if (board[row - 2, col - 1] == 'K')
        {
            attackedKnight++;
        }
        
    }
    // 2 up 1 right
    if (ValidateCell(row - 2, col + 1, size))
    {
        if (board[row - 2, col + 1] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 down 1 left
    if (ValidateCell(row + 2, col - 1, size))
    {
        if (board[row + 2, col - 1] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 down 1 right
    if (ValidateCell(row + 2, col + 1, size))
    {
        if (board[row + 2, col + 1] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 left 1 up
    if (ValidateCell(row - 1, col - 2, size))
    {
        if (board[row - 1, col - 2] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 left 1 down
    if (ValidateCell(row + 1, col - 2, size))
    {
        if (board[row + 1, col - 2] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 right 1 up
    if (ValidateCell(row - 1, col + 2, size))
    {
        if (board[row - 1, col + 2] == 'K')
        {
            attackedKnight++;
        }
    }
    // 2 right 1 down 
    if (ValidateCell(row + 1, col + 2, size))
    {
        if (board[row + 1, col + 2] == 'K')
        {
            attackedKnight++;
        }
    }

    return attackedKnight;
}

static bool ValidateCell(int row, int col, int size)
{
    return
        row >= 0 && row < size && col >= 0 && col < size;
}