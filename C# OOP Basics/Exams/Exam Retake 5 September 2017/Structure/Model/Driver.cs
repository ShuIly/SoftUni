public abstract class Driver
{
    protected Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.TotalTime = 0;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public string Name { get; }
    public double TotalTime { get; protected set; }
    public Car Car { get; }
    public double FuelConsumptionPerKm { get; }
    public virtual double Speed => (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;
}
