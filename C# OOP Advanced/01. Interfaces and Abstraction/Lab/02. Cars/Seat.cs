using System;

class Seat : ICar
{
    private string model;
    private string color;

    public string Model
    {
        get => this.model;
        private set
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
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Color)} cannot be null or whitespace.");
            }

            this.color = value;
        }
    }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} {this.GetType().Name} {this.Model}\n" +
               Start() + "\n" + Stop();
    }
}
