using Polymorphism_AddOn.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AddOn.Models
{
    public class Truck : Vehicle
    {
        private const double AdditionalFuelConsumptionTruck = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + AdditionalFuelConsumptionTruck;
        }
        public override void Drive(double distance)
        {
            if (distance * FuelConsumption > FuelQuantity)
            {
                Console.WriteLine("Truck needs refueling");
                return;
            }

            FuelQuantity -= distance * FuelConsumption;
            Console.WriteLine($"Truck travelled {distance} km");
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel * 0.95;
        }
    }
}
