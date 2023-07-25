using Polymorphism_AddOn.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AddOn.Models
{
    public class Car : Vehicle
    {
        private const double AdditionalFuelConsumptionCar = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + AdditionalFuelConsumptionCar;
        }

        public override void Drive(double distance)
        {
            if (distance * FuelConsumption > FuelQuantity)
            {
                Console.WriteLine("Car needs refueling");
                return;
            }

            FuelQuantity -= distance * FuelConsumption;
            Console.WriteLine($"Car travelled {distance} km");
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel;
        }
    }
}
