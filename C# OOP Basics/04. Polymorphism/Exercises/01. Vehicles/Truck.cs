class Truck : Car
{
    protected override double ACFuelConsumption => 1.6;
    protected override double FuelRefillPercentage => 0.95;

    public Truck(double fuelQuantity, double fuelConsumption) 
        : base(fuelQuantity, fuelConsumption)
    {
    }
}
