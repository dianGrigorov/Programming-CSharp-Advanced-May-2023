Stack<int> dailyPortion = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> stamina = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string, int> peaks = new()
{
    { "Vihren", 80},
    { "Kutelo", 90},
    {"Banski Suhodol", 100},
    { "Polezhan", 60},
    { "Kamenitza", 70},
};
List<string> conqueredPeaks = new();
for (int j = 1; j <= 7; j++)
{
    if (dailyPortion.Count > 0)
    {
        int resul = dailyPortion.Pop() + stamina.Dequeue();
        int currPeak = peaks.First().Value;
        string currPeakName = peaks.First().Key;
        if (resul >= currPeak)
        {
            peaks.Remove(currPeakName);
            conqueredPeaks.Add(currPeakName);
            if (peaks.Count == 0)
            {
                break;
            }
        }
    }
    else
    {
        break;
    }
    
}

if (peaks.Count == 0)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
if (conqueredPeaks.Count > 0)
{
    Console.WriteLine("Conquered peaks:");
    foreach (var peak in conqueredPeaks)
    {
        Console.WriteLine(peak);
    }
}