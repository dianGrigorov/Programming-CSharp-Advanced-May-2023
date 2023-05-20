int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[]sortedNumbers = numbers.OrderByDescending(n => n).ToArray();
for (int i = 0; i < 3 && i < sortedNumbers.Length; i++)
{
    Console.Write($"{sortedNumbers[i]} ");
}