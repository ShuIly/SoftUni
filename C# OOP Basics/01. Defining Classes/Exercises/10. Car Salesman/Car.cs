class Car
{
    public string Model { get; }
    private Engine engine;
    private double weight;
    private string color;

    public Car(string model, Engine engine, double weight, string color)
    {
        this.Model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        return $"{this.Model}:\n" + engine;
    }
}
