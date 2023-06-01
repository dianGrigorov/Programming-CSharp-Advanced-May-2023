
namespace SpeedRacing;
public class StartUp
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        for (int i = 0; i < count; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);

            cars.Add(new Car(model, fuelAmount, fuelConsumption));
        }

        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = tokens[1];
            double distance = double.Parse(tokens[2]);

            foreach (var car in cars)
            {
                if (car.Model == carModel)
                {
                    if (car.Drive(car.FuelAmount, car.FuelConsumptionPerKilometer, distance))
                    {
                        car.FuelAmount -= distance * car.FuelConsumptionPerKilometer;
                        car.Travelled += distance;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Travelled}");
        }

    }
}