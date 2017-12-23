using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var cars = new Dictionary<string, Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] carArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = carArgs[0];
            double fuelAmount = double.Parse(carArgs[1]);
            double fuelForKilometer = double.Parse(carArgs[2]);

            if (!cars.ContainsKey(model))
            {
                cars.Add(model, new Car(model, fuelAmount, fuelForKilometer));
            }
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string model = inputArgs[1];
            double driveDistance = double.Parse(inputArgs[2]);

            try
            {
                cars[model].Drive(driveDistance);
            }
            catch (Exception e)
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
