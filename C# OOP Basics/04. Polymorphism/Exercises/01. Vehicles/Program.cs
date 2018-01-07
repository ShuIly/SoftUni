using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        string[] carArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] truckArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        cars.Add("Car", new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2])));
        cars.Add("Truck", new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2])));

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
                        cars[carType].Drive(amount);
                        Console.WriteLine($"{cars[carType].GetType().Name} travelled {amount} km");
                        break;
                    case "Refuel":
                        cars[carType].Refuel(amount);
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
    }
}
