using System;

public class Tyre
{
    private const int MinDegradation = 0;
    private const int MaxDegradation = 100;

    private double degradation;

    public Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.degradation = MaxDegradation;
    }

    public string Name { get; }
    public double Hardness { get; protected set; }

    public virtual double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value < MinDegradation)
            {
                throw new ArgumentException(OutputMessages.BlownTyre);
            }

            this.degradation = value;
        }
    }

    public virtual void CompleteLap()
    {
        this.Degradation -= this.Hardness;
    }
}
