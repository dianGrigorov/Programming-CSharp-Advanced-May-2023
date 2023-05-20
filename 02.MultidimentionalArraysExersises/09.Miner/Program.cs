using System.ComponentModel.Design;

int size = int.Parse(Console.ReadLine());

Queue<string> commands = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries));
char[,] field = new char[size, size];
int coals = 0;
int playerRow = 0;
int playerCol = 0;


for (int row = 0; row < size; row++)
{
    char[] chars = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        field[row, col] = chars[col];
        if (field[row, col] == 'c')
        {
            coals++;
        }
        if (field[row, col] == 's')
        {
            playerRow = row;
            playerCol = col;
        }
    }
}

int currRow = playerRow;
int currCol = playerCol;
while (commands.Any())
{
    bool isEnd = false;
    string currComand = commands.Dequeue();
    if (currComand == "up")
    {
        if (currRow > 0)
        {
            currRow--;
            isEnd = ProcessCell(currRow, currCol, ref coals, field);
        }
    }
    if (currComand == "down")
    {
        if (currRow < size - 1)
        {
            currRow++;
            isEnd = ProcessCell(currRow, currCol, ref coals, field);
        }
    }
    if (currComand == "left")
    {
        if (currCol > 0)
        {
            currCol--;
            isEnd = ProcessCell(currRow, currCol, ref coals, field);
        }
    }
    if (currComand == "right")
    {
        if (currCol < size - 1)
        {
            currCol++;
            isEnd = ProcessCell(currRow, currCol, ref coals, field);
        }
    }
    if (isEnd)
    {
        break;
    }
}
if (field[currRow, currCol] == 'e')
{
    Console.WriteLine($"Game over! ({currRow}, {currCol})");
}
else if (coals == 0)
{
    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");

}
else
{
    Console.WriteLine($"{coals} coals left. ({currRow}, {currCol})");
}

static bool ProcessCell(int row, int col, ref int coals, char[,] field)
{
    if (field[row, col] == 'e')
    {
        return true;
    }
    else if (field[row, col] == 'c')
    {

        field[row, col] = '*';
        coals--;

        if (coals == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}
