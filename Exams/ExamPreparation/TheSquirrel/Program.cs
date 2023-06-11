int size = int.Parse(Console.ReadLine());

string[] commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

char[,] fieald = new char[size, size];
int positionRow = 0;
int positionCol = 0;
int hazelnuts = 0;
bool flag = true;

for (int row = 0; row < size; row++)
{
    string tokens = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        fieald[row, col] = tokens[col];
        if (tokens[col] == 's')
        {
            positionRow = row;
            positionCol = col;
        }
    }
}

foreach (string command in commands)
{
    if (command == "up")
    {
        if (positionRow - 1 >= 0)
        {
            fieald[positionRow, positionCol] = '*';
            positionRow--;
            if (fieald[positionRow, positionCol] == 'h')
            {
                fieald[positionRow, positionCol] = 's';
                hazelnuts++;
                if (hazelnuts == 3)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    fieald[positionRow, positionCol] = 's';
                    flag = false;
                    break;
                }
            }
            if (fieald[positionRow, positionCol] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                flag = false;
                break;
            }


            fieald[positionRow, positionCol] = 's';
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            flag = false;
            break;
        }

    }
    else if (command == "down")
    {
        if (positionRow + 1 < size)
        {
            fieald[positionRow, positionCol] = '*';
            positionRow++;
            if (fieald[positionRow, positionCol] == 'h')
            {
                fieald[positionRow, positionCol] = 's';
                hazelnuts++;
                if (hazelnuts == 3)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    fieald[positionRow, positionCol] = 's';
                    flag = false;
                    break;
                }
            }
            if (fieald[positionRow, positionCol] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                flag = false;
                break;
            }
            fieald[positionRow, positionCol] = 's';
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            flag = false;
            break;
        }
    }
    else if (command == "left")
    {
        if (positionCol - 1 >= 0)
        {
            fieald[positionRow, positionCol] = '*';
            positionCol--;
            if (fieald[positionRow, positionCol] == 'h')
            {
                fieald[positionRow, positionCol] = 's';
                hazelnuts++;
                if (hazelnuts == 3)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    fieald[positionRow, positionCol] = 's';
                    flag = false;
                    break;
                }
            }
            if (fieald[positionRow, positionCol] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                flag = false;
                break;
            }
            fieald[positionRow, positionCol] = 's';
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            flag = false;
            break;
        }
    }
    else if (command == "right")
    {

        if (positionCol + 1 < size)
        {
            fieald[positionRow, positionCol] = '*';
            positionCol++;
            if (fieald[positionRow, positionCol] == 'h')
            {
                fieald[positionRow, positionCol] = 's';
                hazelnuts++;
                if (hazelnuts == 3)
                {
                    Console.WriteLine("Good job! You have collected all hazelnuts!");
                    fieald[positionRow, positionCol] = 's';
                    flag = false;
                    break;
                }
            }
            if (fieald[positionRow, positionCol] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                flag = false;
                break;
            }
            fieald[positionRow, positionCol] = 's';
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            flag = false;
            break;
        }
    }
}

if (flag)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {hazelnuts}");
