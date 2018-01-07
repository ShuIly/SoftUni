using System;

class Car
{
    protected virtual double ACFuelConsumption => 0.9;
    protected virtual double FuelRefillPercentage => 1;

    private double fuelQuantity;

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.fuelQuantity = value;
        }
    }

    public double FuelConsumption { get; }

    public Car(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + ACFuelConsumption;
    }

    public void Drive(double distance)
    {
        double neededFuel = this.FuelConsumption * distance;
        this.FuelQuantity -= neededFuel;
    }

    public void Refuel(double amount)
    {
        this.FuelQuantity += amount * FuelRefillPercentage;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
