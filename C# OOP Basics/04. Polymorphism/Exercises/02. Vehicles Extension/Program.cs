using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        string[] carArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] truckArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] busArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        vehicles.Add("Car", new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3])));
        vehicles.Add("Truck", new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3])));
        vehicles.Add("Bus", new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3])));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string carType = cmdArgs[1];
            double amount = double.Parse(cmdArgs[2]);

            try
            {
                switch (cmdArgs[0])
                {
                    case "Drive":
                        vehicles[carType].DriveWithAc(amount);
                        Console.WriteLine($"{vehicles[carType].GetType().Name} travelled {amount} km");
                        break;
                    case "DriveEmpty":
                        vehicles[carType].Drive(amount);
                        Console.WriteLine($"{vehicles[carType].GetType().Name} travelled {amount} km");
                        break;
                    case "Refuel":
                        vehicles[carType].Refuel(amount);
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var vehicle in vehicles.Values)
        {
            Console.WriteLine(vehicle);
        }
    }
}
