
using GenericBoxOfStrings;

Box<double> box = new Box<double>();
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    double input = double.Parse(Console.ReadLine());
    box.Add(input);
}

double itemToCompare = double.Parse(Console.ReadLine());

Console.WriteLine(box.Count(itemToCompare));
