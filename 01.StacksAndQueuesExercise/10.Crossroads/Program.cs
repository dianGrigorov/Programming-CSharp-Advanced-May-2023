int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());
Queue<string> carsQueue = new Queue<string>();
int carsCount = 0;
string commands;

while ((commands = Console.ReadLine()) != "END")
{
    string car = commands;
    if (car == "green")
    {
        int currGreenLiteDuratin = greenLightDuration;

        while (carsQueue.Count > 0 && currGreenLiteDuratin > 0)
        {

            int carLenght = carsQueue.Peek().Length;
           
            if (carLenght <= currGreenLiteDuratin)
            {
                currGreenLiteDuratin -= carLenght;
                
            }
            else
            {
                carLenght -= currGreenLiteDuratin;
                currGreenLiteDuratin = 0;

                if (carLenght > freeWindowDuration)
                {
                    int index = carsQueue.Peek().Length - (carLenght - freeWindowDuration);
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{carsQueue.Peek()} was hit at {carsQueue.Peek()[index]}.");
                    return;
                }
            }
            carsQueue.Dequeue();
            carsCount++;
        }
    }
    else
    {
        carsQueue.Enqueue(car);
    }

}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsCount} total cars passed the crossroads.");