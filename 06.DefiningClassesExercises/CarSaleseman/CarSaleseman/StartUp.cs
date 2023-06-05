using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CarSaleseman;

public class StartUp
{
    static void Main(string[] args)
    {

        int engineCount = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();

        for (int i = 0; i < engineCount; i++)
        {
            string[] engine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Engine currEngine = new(engine[0], int.Parse(engine[1]));

            if (engine.Length == 3)
            {
                bool res;
                int disp;
                res = int.TryParse(engine[2], out disp);
                if (res)
                {
                    currEngine.Displacement = disp;
                }
                else
                {
                    currEngine.Efficiency = engine[2];
                }
                
            }
            if (engine.Length == 4)
            {
                currEngine.Displacement = int.Parse(engine[2]);
                currEngine.Efficiency = engine[3];
            }
            engines.Add(currEngine);
        }

        int carCount = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

        for (int i = 0; i < carCount; i++)
        {
            string[] car = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Engine engine = new();

            foreach (var item in engines)
            {
                if (item.Model == car[1])
                {
                    engine = item;
                }
            }
            Car currCar = new(car[0], engine);

            if (car.Length == 3)
            {
                bool res;
                int weight;
                res = int.TryParse(car[2], out weight);
                if (res)
                {
                    currCar.Weight = weight;
                }
                else
                {
                    currCar.Color = car[2];
                }
            }
            if (car.Length == 4)
            {
                currCar.Weight = int.Parse(car[2]);
                currCar.Color = car[3];
            }

            cars.Add(currCar);


        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }


}