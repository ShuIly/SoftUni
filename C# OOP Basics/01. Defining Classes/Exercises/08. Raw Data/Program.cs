using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // <Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> 
        // <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>

        var cars = new Dictionary<string, Car>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] carArgs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string model = carArgs[0];
            Engine engine = new Engine(int.Parse(carArgs[1]), int.Parse(carArgs[2]));
            Cargo cargo = new Cargo(int.Parse(carArgs[3]), carArgs[4]);

            List<Tire> tires = new List<Tire>();
            tires.Add(new Tire(double.Parse(carArgs[5]), int.Parse(carArgs[6])));
            tires.Add(new Tire(double.Parse(carArgs[7]), int.Parse(carArgs[8])));
            tires.Add(new Tire(double.Parse(carArgs[9]), int.Parse(carArgs[10])));
            tires.Add(new Tire(double.Parse(carArgs[11]), int.Parse(carArgs[12])));

            cars.Add(model, new Car(engine, cargo, tires, model));
        }

        string type = Console.ReadLine();
        foreach (var car in cars.Values
            .Where(c => c.Type.ToLower() == type))
        {
            Console.WriteLine(car.Model);
        }
    }
}
