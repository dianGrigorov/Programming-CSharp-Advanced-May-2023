using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    internal class Car
    {
		private string model;
		private double fuelAmount;
		private double  fuelConsumptionPerKilometer;
		private double travelled;
        public Car()
        {
            travelled = 0;
        }
		public Car(string model, double fuelAmount, double fuelConsumption) :this()
        {
			Model = model;
			FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
        }
        public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}

		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}

		public double Travelled
        {
			get { return travelled; }
			set { travelled = value; }
		}

		public bool Drive(double fuelAmount, double fuelConsumption, double distance)
		{
			if (fuelAmount >= fuelConsumption * distance)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
