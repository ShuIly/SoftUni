using System;

class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption, double fuelCapacity)
        : base(fuelQuantity, fuelConsumption, fuelCapacity)
    {
    }

    public override double FuelQuantity
    {
        get => base.FuelQuantity;
        protected set
        {
            if (value > this.FuelCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }

            base.FuelQuantity = value;
        }
    }

}
