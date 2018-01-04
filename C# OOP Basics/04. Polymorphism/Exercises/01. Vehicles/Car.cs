using System;

class Car
{
    protected virtual double AdditionalFuelConsumption => 0.9;
    protected virtual double FuelRefillPercentage => 1;

    private double fuelQuantity;

    public double FuelQuantity
    {
        get => this.fuelQuantity;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(FuelQuantity)} cannot be negative.");
            }

            this.fuelQuantity = value;
        }
    }

    public double FuelConsumption { get; }

    public Car(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + AdditionalFuelConsumption;
    }

    public void Drive(double distance)
    {
        var neededFuel = this.FuelConsumption * distance;

        if (neededFuel > this.FuelQuantity)
        {
            throw new ArgumentException();
        }

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
