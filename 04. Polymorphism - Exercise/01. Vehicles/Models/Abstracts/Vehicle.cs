using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_AddOn.Models.Abstracts
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }

        public abstract void Drive(double distance);
        public abstract void Refuel(double fuel);
    }
}
