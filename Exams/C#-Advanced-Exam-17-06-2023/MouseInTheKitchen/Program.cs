string dimentions = Console.ReadLine();
int[] rowsCols = dimentions.Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();


int rows = rowsCols[0];
int cols = rowsCols[1];

char[,] matrix = new char[rows, cols];
int startRow = 0;
int startCol = 0;
int cheese = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string tokens = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = tokens[col];
        if (matrix[row, col] == 'C')
        {
            cheese++;
        }
        if (matrix[row, col] == 'M')
        {
            startRow = row;
            startCol = col;
            matrix[row, col] = '*';
        }
    }
}

string command;
bool isTraped = false;
bool eatAllCheese = false;
bool isOutside = false;
while ((command = Console.ReadLine()) != "danger")
{
    int nextRow = startRow;
    int nextCol = startCol;
    if (command == "up")
    {
        nextRow--;
    }
    if(command == "down")
    {
        nextRow++;
    }
    if (command == "right")
    {
        nextCol++;
    }
    if (command == "left")
    {
        nextCol--;
    }

    if (IsValidPosotion(nextRow, nextCol))
    {
        if (matrix[nextRow, nextCol] == 'C')
        {
            matrix[startRow, startCol] = '*';
            matrix[nextRow, nextCol] = 'M';
            cheese--;
            if (cheese == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                matrix[nextRow, nextCol] = 'M';
                eatAllCheese = true;
                break;
            }
            startRow = nextRow;
            startCol = nextCol;
            
        }
        else if (matrix[nextRow, nextCol] == 'T')
        {
            Console.WriteLine("Mouse is trapped!");
            matrix[nextRow, nextCol] = 'M';
            matrix[startRow, startCol] = '*';
            startRow = nextRow;
            startCol = nextCol;
            isTraped = true;
            break;
        }
        else if(matrix[nextRow, nextCol] == '@')
        {
            matrix[startRow, startCol] = 'M';
            nextRow = startRow;
            nextCol = startCol;
        }
        else
        {
            matrix[startRow, startCol] = '*';
            matrix[nextRow, nextCol] = 'M';
            startRow = nextRow;
            startCol = nextCol;
          
        }
    }
    else
    {
        Console.WriteLine("No more cheese for tonight!");
        matrix[startRow, startCol] = 'M';
        isOutside = true;
        break;
    }
}

if (cheese > 0 && !isTraped && !eatAllCheese && !isOutside)
{
   
    Console.WriteLine("Mouse will come back later!");
}

PrintMatrix(matrix);
bool IsValidPosotion(int row, int col)
{
    return row >= 0 && row < matrix.GetLength(0)
        && col >= 0 && col < matrix.GetLength(1);
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