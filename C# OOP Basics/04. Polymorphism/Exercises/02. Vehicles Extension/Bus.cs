using System;

class Bus : Car
{
    protected override double ACFuelConsumption => 1.4;

    public Bus(double fuelQuantity, double fuelConsumption, double fuelCapacity) 
        : base(fuelQuantity, fuelConsumption, fuelCapacity)
    {
    }
}
