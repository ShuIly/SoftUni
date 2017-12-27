class Car
{
    public string Model { get; }
    public int Speed { get; }

    public Car(string model, int speed)
    {
        this.Model = model;
        this.Speed = speed;
    }

    public override string ToString()
    {
        return $"{this.Model} {this.Speed}\n";
    }
}
