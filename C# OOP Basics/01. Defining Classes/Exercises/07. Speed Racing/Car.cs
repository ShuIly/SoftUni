using System;

class Car
{
    private double fuelAmount;
    private readonly double fuelForKilometer;
    private double distanceTraveled;

    public string Model { get; }

    public double Fuel
    {
        get => this.fuelAmount;
        private set
        {
            if (value < 0)
            {
                throw new Exception("Insufficient fuel for the drive");
            }

            fuelAmount = value;
        }
    }

    public double DistanceTraveled => this.distanceTraveled;

    public Car(string model, double fuelAmount, double fuelForKilometer)
    {
        this.Model = model;
        this.fuelAmount = fuelAmount;
        this.fuelForKilometer = fuelForKilometer;
        this.distanceTraveled = 0;
    }

    public void Drive(double driveKilometers)
    {
        double fuelRequired = driveKilometers * fuelForKilometer;

        this.Fuel -= fuelRequired;
        this.distanceTraveled += driveKilometers;
    }

    public override string ToString()
    {
        return $"{this.Model} {this.Fuel:f2} {this.DistanceTraveled}";
    }
}
