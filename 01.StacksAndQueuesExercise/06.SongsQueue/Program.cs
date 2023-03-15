using System.Linq;

string[] songs = Console.ReadLine().Split(", ");

Queue<string> songsQueue = new Queue<string>(songs);

while (songsQueue.Count > 0)
{
    string[] commandArg = Console.ReadLine().Split();
    string currCom = commandArg[0];

    if (currCom == "Play")
    {
        songsQueue.Dequeue();
        if (songsQueue.Count == 0 )
        {
            Console.WriteLine("No more songs!");
        }
        
    }
    else if (currCom == "Add")
    {
        string song = string.Join(" ", commandArg.Skip(1));
        if (songsQueue.Contains(song))
        {
            Console.WriteLine($"{song} is already contained!");
        }
        else
        {
            songsQueue.Enqueue(song);
        }
    }
    else if (currCom == "Show")
    {
        Console.WriteLine(string.Join(", ", songsQueue));
    }
    
}