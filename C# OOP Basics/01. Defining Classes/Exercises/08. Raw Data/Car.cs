using System.Collections.Generic;

class Car
{
    // model, engine, cargo and a collection of exactly 4 tires.
    // The engine, cargo and tire should be separate classes

    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public string Model { get; }
    public string Type { get; }
    

    public Car(Engine engine, Cargo cargo, List<Tire> tires, string model)
    {
        Model = model;
        this.Type = "n/a";

        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;

        if (engine.Power > 250)
        {
            Type = "Flamable";
        }

        foreach (var tire in tires)
        {
            if (tire.Pressure < 1)
            {
                this.Type = "Fragile";
                break;
            }
        }
    }
}
