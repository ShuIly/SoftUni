using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var engines = new Dictionary<string, Engine>();

        int engineCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < engineCount; i++)
        {
            string[] engineArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Engine engine = null;

            switch (engineArgs.Length)
            {
                case 4:
                    engine = new Engine(engineArgs[0], int.Parse(engineArgs[1]), int.Parse(engineArgs[2]), engineArgs[3]);
                    break;
                case 3:
                    if (int.TryParse(engineArgs[2], out int displacements))
                        engine = new Engine(engineArgs[0], int.Parse(engineArgs[1]), displacements);
                    else
                        engine = new Engine(engineArgs[0], int.Parse(engineArgs[1]), engineArgs[2]);
                    break;
                default:
                    engine = new Engine(engineArgs[0], int.Parse(engineArgs[1]));
                    break;
            }

            engines.Add(engineArgs[0], engine);
        }

        List<Car> cars = new List<Car>();

        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            // <Model> <Engine> <Weight> <Color>
            string[] carArgs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            Car car = null;

            switch (carArgs.Length)
            {
                case 4:
                    car = new Car(carArgs[0], engines[carArgs[1]], int.Parse(carArgs[2]), carArgs[3]);
                    break;
                case 3:
                    if (int.TryParse(carArgs[2], out int weight))
                        car = new Car(carArgs[0], engines[carArgs[1]], weight);
                    else
                        car = new Car(carArgs[0], engines[carArgs[1]], carArgs[2]);
                    break;
                default:
                    car = new Car(carArgs[0], engines[carArgs[1]]);
                    break;
            }

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
