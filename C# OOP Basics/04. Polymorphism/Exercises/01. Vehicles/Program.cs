using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        string[] carArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] truckArgs = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        cars.Add(new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2])));
        cars.Add(new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2])));

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int index = cmdArgs[1] == "Car" ? 0 : 1;


            switch (cmdArgs[0])
            {
                case "Drive":
                    try
                    {
                        // If you're getting 62/100 points this line will save you.
                        // There's probably input like "00123" that should get parsed and converted to "123".
                        double amount = double.Parse(cmdArgs[2]);
                        cars[index].Drive(amount);
                        Console.WriteLine($"{cars[index].GetType().Name} travelled {amount} km");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine($"{cars[index].GetType().Name} needs refueling");
                    }
                    break;
                case "Refuel":
                    cars[index].Refuel(double.Parse(cmdArgs[2]));
                    break;
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
