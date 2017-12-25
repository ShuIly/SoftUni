class Car
{
    public string Model { get; }
    private Engine engine;
    private int weight;
    private string color;

    public Car(string model, Engine engine, int weight, string color)
    {
        this.Model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    public Car(string model, Engine engine)
        : this(model, engine, -1, "n/a") { }

    public Car(string model, Engine engine, int weight)
        : this(model, engine, weight, "n/a") { }

    public Car(string model, Engine engine, string color)
        : this(model, engine, -1, color) { }

    public override string ToString()
    {
        return $"{this.Model}:\n" + engine
            + $"  Weight: {(this.weight == -1 ? "n/a" : this.weight.ToString())}\n"
            + $"  Color: {this.color}";
    }
}
