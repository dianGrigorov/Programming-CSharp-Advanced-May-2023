int size = int.Parse(Console.ReadLine());

char[,] field = new char[size, size];
int moleRow = 0;
int moleCol = 0;
int firstSpecilRow = 0;
int firstSpecilCol = 0;
int secondSpecialRow = 0;
int secondSpecialCol = 0;
bool isFirstSpecialFound = false;
int points = 0;
for (int row = 0; row < size; row++)
{
    string tokens = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        field[row, col] = tokens[col];
        if (field[row, col] == 'M')
        {
            moleRow = row;
            moleCol = col;
        }
        else if (field[row, col] == 'S' && !isFirstSpecialFound)
        {
            firstSpecilRow = row;
            firstSpecilCol = col;
            isFirstSpecialFound = true;
        }
        else if (field[row, col] == 'S')
        {
            secondSpecialRow = row;
            secondSpecialCol = col;
        }

    }
}
bool winTheGame = false;
string command;
while ((command = Console.ReadLine()) != "End")
{

    if (command == "up")
    {
        Move(ref moleRow, ref moleCol, -1, 0, ref points);

    }
    else if (command == "down")
    {
        Move(ref moleRow, ref moleCol, 1, 0, ref points);

    }
    else if (command == "left")
    {
        Move(ref moleRow, ref moleCol, 0, -1, ref points);

    }
    else if (command == "right")
    {
        Move(ref moleRow, ref moleCol, 0, 1, ref points);

    }
    if (points >= 25)
    {
        winTheGame = true;
        break;
    }
}


if (winTheGame)
{
    Console.WriteLine("Yay! The Mole survived another game!");
    Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
}
else
{
    Console.WriteLine("Too bad! The Mole lost this battle!");
    Console.WriteLine($"The Mole lost the game with a total of {points} points.");
}

PrintMatrix(field);
bool IsInside(int row, int col)
{
    return row >= 0 && row < field.GetLength(0)
        && col >= 0 && col < field.GetLength(1);

}

void Move(
    ref int moleRow,
    ref int moleCol,
    int nextRow,
    int nextCol,
    ref int points)
{
    if (IsInside(moleRow + nextRow, moleCol + nextCol))
    {

        if (field[moleRow + nextRow, moleCol + nextCol] == '-')
        {
            field[moleRow, moleCol] = '-';
            moleRow += nextRow;
            moleCol += nextCol;
        }
        else if (char.IsDigit(field[moleRow + nextRow, moleCol + nextCol]))
        {
            field[moleRow, moleCol] = '-';
            moleRow += nextRow;
            moleCol += nextCol;
            points += int.Parse(field[moleRow, moleCol].ToString()); ;
        }
        else if (field[moleRow + nextRow, moleCol + nextCol] == 'S')
        {
            field[moleRow, moleCol] = '-';
            moleRow += nextRow;
            moleCol += nextCol;
            if (moleRow == firstSpecilRow && moleCol == firstSpecilCol)
            {
                moleRow = secondSpecialRow;
                moleCol = secondSpecialCol;
                field[firstSpecilRow, firstSpecilCol] = '-';
            }
            else if (moleRow == secondSpecialRow && moleCol == secondSpecialCol)
            {
                moleRow = firstSpecilRow;
                moleCol = firstSpecilCol;
                field[secondSpecialRow, secondSpecialCol] = '-';
            }
            points -= 3;
        }
        field[moleRow, moleCol] = 'M';
    }
    else
    {
        Console.WriteLine("Don't try to escape the playing field!");

    }
}
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