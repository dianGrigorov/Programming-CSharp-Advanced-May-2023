HashSet<string> carPlate =  new HashSet<string>();
string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] commArg = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string currCom = commArg[0];
    string plate = commArg[1];
    if (currCom == "IN")
    {
        carPlate.Add(plate);
    }
    if(currCom == "OUT")
    {
        carPlate.Remove(plate);
    }
}
if (carPlate.Any())
{
    foreach (var plate in carPlate)
    {
        Console.WriteLine(plate);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}