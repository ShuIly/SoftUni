using System;

class Vehicle
{
    protected virtual double ACFuelConsumption => 0.9;
    protected virtual double FuelRefillPercentage => 1;

    private double fuelQuantity;
    private readonly double fuelConsumption;
    private double fuelCapacity;

    public virtual  double FuelQuantity
    {
        get => this.fuelQuantity;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.fuelQuantity = value;
        }
    }
    
    public double FuelCapacity
    {
        get => this.fuelCapacity;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{this.GetType().Name} must be positive.");
            }

            this.fuelCapacity = value;
        }
    }

    public Vehicle(double fuelQuantity, double fuelConsumption, double fuelCapacity)
    {
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
        this.fuelCapacity = fuelCapacity;
    }

    public void Drive(double distance)
    {
        double neededFuel = this.fuelConsumption * distance;
        this.FuelQuantity -= neededFuel;
    }

    public void DriveWithAc(double distance)
    {
        double neededFuel = (this.fuelConsumption + this.ACFuelConsumption) * distance;
        this.FuelQuantity -= neededFuel;
    }

    public void Refuel(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        this.FuelQuantity += amount * FuelRefillPercentage;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
