class Truck : Vehicle
{
    protected override double ACFuelConsumption => 1.6;
    protected override double FuelRefillPercentage => 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double fuelCapacity) 
        : base(fuelQuantity, fuelConsumption, fuelCapacity)
    {
    }
}
