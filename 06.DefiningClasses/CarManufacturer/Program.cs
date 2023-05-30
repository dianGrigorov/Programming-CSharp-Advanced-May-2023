namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car car = new Car()
        {
            Make = "VW",
            Model = "Pasat",
            Year = 2006,
            FuelQuantity = 200,
            FuelConsumption = 200,

        };
        car.Drive(2000);
        Console.WriteLine(car.WhoAmI());

        
    }
}
