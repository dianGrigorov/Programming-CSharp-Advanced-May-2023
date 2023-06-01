namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
      
        var tires = new Tire[4]
        {
            new Tire(2,2.3),
            new Tire(2,2.3),
            new Tire(2,2.2),
            new Tire(2,2.2),
        };

        Engine engine = new Engine(200, 2);

        var car = new Car("Lambo", "Urus", 2010, 250, 9 , engine, tires);
        Console.WriteLine(car.WhoAmI());
    }
}
