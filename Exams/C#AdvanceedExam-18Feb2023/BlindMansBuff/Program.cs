using System.Runtime.CompilerServices;

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[,] matrix = new int[size[0], size[1]];
int playerRow = 0;
int playerCol = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] tokens = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = tokens[col];
        if (tokens[col] == 'B')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int moves = 0;
int tuchedOponents = 0;
string command;
while ((command = Console.ReadLine()) != "Finish")
{
    if (command == "down")
    {
        if (playerRow + 1 < size[0])
        {
            if (matrix[playerRow + 1,playerCol] == 'P')
            {
                matrix[playerRow, playerCol] = '-';
                tuchedOponents++;
                moves++;
                playerRow++;
                matrix[playerRow, playerCol] = 'B';
                if(tuchedOponents == 3)
                {
                    break;
                }
            }
            else if (matrix[playerRow + 1, playerCol] == '-')
            {
                matrix[playerRow, playerCol] = '-';
                moves++;
                playerRow++;
                matrix[playerRow, playerCol] = 'B';
            }
           
        }

    }
    else if (command == "up")
    {
        if (playerRow - 1 >= 0 )
        {
            if (matrix[playerRow - 1, playerCol] == 'P')
            {
                matrix[playerRow, playerCol] = '-';
                tuchedOponents++;
                moves++;
                playerRow--;
                matrix[playerRow, playerCol] = 'B';
                if (tuchedOponents == 3)
                {
                    break;
                }
            }
            else if (matrix[playerRow - 1, playerCol] == '-')
            {
                matrix[playerRow, playerCol] = '-';
                moves++;
                playerRow--;
                matrix[playerRow, playerCol] = 'B';
            }

        }
    }
    else if (command == "right")
    {
        if (playerCol + 1 < size[1])
        {
            if (matrix[playerRow, playerCol + 1] == 'P')
            {
                matrix[playerRow, playerCol] = '-';
                tuchedOponents++;
                moves++;
                playerCol++;
                matrix[playerRow, playerCol] = 'B';
                if (tuchedOponents == 3)
                {
                    break;
                }
            }
            else if (matrix[playerRow , playerCol + 1] == '-')
            {
                matrix[playerRow, playerCol] = '-';
                moves++;
                playerCol++;
                matrix[playerRow, playerCol] = 'B';
            }

        }
    }
    else if (command == "left")
    {
        if (playerCol - 1 >= 0)
        {
            if (matrix[playerRow, playerCol - 1] == 'P')
            {
                matrix[playerRow, playerCol] = '-';
                tuchedOponents++;
                moves++;
                playerCol--;
                matrix[playerRow, playerCol] = 'B';
                if (tuchedOponents == 3)
                {
                    break;
                }
            }
            else if (matrix[playerRow , playerCol - 1] == '-')
            {
                matrix[playerRow, playerCol] = '-';
                moves++;
                playerCol--;
                matrix[playerRow, playerCol] = 'B';
            }

        }
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {tuchedOponents} Moves made: {moves}");