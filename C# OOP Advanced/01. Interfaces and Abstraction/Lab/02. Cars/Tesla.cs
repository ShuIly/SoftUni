using System;

class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int battery;

    public string Model
    {
        get => this.model;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Model)} cannot be null or whitespace.");
            }

            this.model = value;
        }
    }

    public string Color
    {
        get => this.color;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Color)} cannot be null or whitespace.");
            }

            this.color = value;
        }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public int Battery
    {
        get => this.battery;
        set
        {
            if (value < 0)
            {
                Console.WriteLine($"{nameof(this.Battery)} cannot be negative.");
            }

            this.battery = value;
        }
    }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public override string ToString()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries\n" +
               Start() + "\n" + Stop();
    }
}
