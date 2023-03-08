
int n = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();
int count = 0;
string input;

while ((input = Console.ReadLine()) != "end")
{

    if (input == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine($"{cars.Dequeue()} passed!");
                count++;
            }
        }
    }
    else
    {
        cars.Enqueue(input);
    }
}
Console.WriteLine($"{count} cars passed the crossroads.");