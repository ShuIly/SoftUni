using System;

public class Car
{
    private const double MaxFuel = 160;

    private double fuelAmount;
    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.FuelAmount = fuelAmount;
        this.Hp = hp;
        this.Tyre = tyre;
    }

    public int Hp { get; }

    public double FuelAmount
    {
        get => this.fuelAmount;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(OutputMessages.OutOfFuel);
            }

            this.fuelAmount = Math.Min(value, MaxFuel);
        }
    }

    public Tyre Tyre { get; private set; }
}
