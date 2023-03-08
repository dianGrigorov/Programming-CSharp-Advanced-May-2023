
string[] input = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());

Queue<string> players = new Queue<string>(input);

while(players.Count != 1)
{
    for(int i = 1; i <= n; i++)
    {
        string currPlayer = players.Dequeue();
        if (i < n)
        {
            players.Enqueue(currPlayer);
        }
        else
        {
            Console.WriteLine($"Removed {currPlayer}");
        }
    }
}
Console.WriteLine($"Last is {players.Peek()}");

