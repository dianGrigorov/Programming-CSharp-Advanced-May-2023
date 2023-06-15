using System;

namespace WallDeatroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'V')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            string command;
            int holes = 1;
            int rods = 0;
            bool isEnd = false;
            while ((command = Console.ReadLine()) != "End")
            {
                int nextRow = startRow;
                int nextCol = startCol;
                if (command == "up")
                {
                    nextRow--;
                }
                else if (command == "down")
                {
                    nextRow++;
                }
                else if (command == "right")
                {
                    nextCol++;
                }
                else if (command == "left")
                {
                    nextCol--;
                }

                if (IsValidPosition(matrix, nextRow, nextCol))
                {
                    if (matrix[nextRow, nextCol] == '-')
                    {
                        matrix[startRow, startCol] = '*';
                        matrix[nextRow, nextCol] = 'V';
                        startRow = nextRow;
                        startCol = nextCol;
                        holes++;
                    }
                    else if (matrix[nextRow, nextCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rods++;
                    }
                    else if (matrix[nextRow, nextCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{nextRow}, {nextCol}]!");
                        matrix[startRow, startCol] = '*';
                        startRow = nextRow;
                        startCol = nextCol;
                        matrix[startRow, startCol] = 'V';
                    }
                    else if (matrix[nextRow, nextCol] == 'C')
                    {
                        matrix[startRow, startCol] = '*';
                        matrix[nextRow, nextCol] = 'E';
                        isEnd = true;
                        holes++;
                        break;
                    }
                   
                }
              
            }

            if (!isEnd)
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
            }
            else
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }

            PrintMatrix(matrix);

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

            static bool IsValidPosition(char[,] matrix, int nextRow, int nextCol)
            {
                return nextRow >= 0 && nextRow < matrix.GetLength(0)
                     && nextCol >= 0 && nextCol < matrix.GetLength(1);
            }
        }


        

       
    }
}
