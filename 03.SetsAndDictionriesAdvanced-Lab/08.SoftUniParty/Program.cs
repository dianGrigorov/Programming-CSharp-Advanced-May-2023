HashSet<string> invited = new HashSet<string>();
HashSet<string> invitedVip = new HashSet<string>();

string command = Console.ReadLine();
while (true)
{
    if (command == "PARTY")
    {
        while ((command = Console.ReadLine()) != "END")
        {
            invited.Remove(command);
            invitedVip.Remove(command);
        }
        break;
    }
    else
    {
        bool isDigit = Char.IsDigit(command[0]);
        if (isDigit)
        {
            invitedVip.Add(command);
        }
        else
        {
            invited.Add(command);
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine(invited.Count + invitedVip.Count);

foreach (var guest in invitedVip)
{
    Console.WriteLine(guest);
}
foreach (var guest in invited)
{
    Console.WriteLine(guest);
}