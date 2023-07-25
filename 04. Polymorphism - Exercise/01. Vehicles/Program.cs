

using Polymorphism_AddOn.Models;
using Polymorphism_AddOn.Models.Abstracts;

string[] carTokens = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] truckTokens = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Car car = new(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
Truck truck = new(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    string[] inputTokens = input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string commandType = inputTokens[0];
    string vehicleType = inputTokens[1];

    switch (commandType)
    {
        case "Drive":
            if (vehicleType == "Car")
                car.Drive(double.Parse(inputTokens[2]));
            else
                truck.Drive(double.Parse(inputTokens[2]));
            break;
        case "Refuel":
            if (vehicleType == "Car")
                car.Refuel(double.Parse(inputTokens[2]));
            else
                truck.Refuel(double.Parse(inputTokens[2]));
            break;
    }
}

Console.WriteLine($"Car: {car.FuelQuantity:f2}");
Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");