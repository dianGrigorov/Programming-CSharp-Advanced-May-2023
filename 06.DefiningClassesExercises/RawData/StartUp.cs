
using RawData;

public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < count; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = new(
                carInfo[0],
                int.Parse(carInfo[1]),
                int.Parse(carInfo[2]),
                int.Parse(carInfo[3]),
                carInfo[4],
                double.Parse(carInfo[5]),
                int.Parse(carInfo[6]),
                 double.Parse(carInfo[7]),
                int.Parse(carInfo[8]),
                 double.Parse(carInfo[9]),
                int.Parse(carInfo[10]),
                 double.Parse(carInfo[11]),
                int.Parse(carInfo[12]));
            cars.Add(car);
        }

        string command = Console.ReadLine();

        foreach (var car in cars)
        {
            if (command == "fragile")
            {
                if (car.Cargo.Type == "fragile" && car.Tires.Any(p => p.Pressure < 1))
                {
                    Console.WriteLine(car.Model);
                }
            }
            if (command == "flammable")
            {
                if (car.Cargo.Type == "flammable" && car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }

    }
}