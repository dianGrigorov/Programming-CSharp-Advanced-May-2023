using System.Linq;

string[] songs = Console.ReadLine().Split(", ");

Queue<string> songsQueue = new Queue<string>(songs);

while (true)
{
    string[] commandArg = Console.ReadLine().Split();
    string currCom = commandArg[0];

    if (currCom == "Play")
    {
        if (songsQueue.Count > 0 )
        {
            songsQueue.Dequeue();
        }
        else
        {
            Console.WriteLine("No more songs!");
            break;
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