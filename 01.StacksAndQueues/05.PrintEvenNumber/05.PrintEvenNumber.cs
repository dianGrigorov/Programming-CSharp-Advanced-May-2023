
int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> evenNumbers = new Queue<int>();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        evenNumbers.Enqueue(arr[i]);
    }
    break;
}

Console.WriteLine(string.Join(", ", evenNumbers));

