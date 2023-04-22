int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jaggedArray[row] = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
}

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] tokens = command.Split();
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        if (tokens[0] == "add")
        {
            jaggedArray[row][col] += value;
        }
        else
        {
            jaggedArray[row][col] -= value;
        }
    }
    command = Console.ReadLine().ToLower();
}

foreach (int[] item in jaggedArray)
{
    Console.WriteLine(string.Join(" ", item));
}