using System;

public abstract class Provider
{
    private const int MaxEnergyOutput = 10000;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id { get; private set; }
    public double EnergyOutput
    {
        get => this.energyOutput;
        protected set
        {
            if (value < 0 || value >= MaxEnergyOutput)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }

            this.energyOutput = value;
        } 
    }

    public override string ToString()
    {
        string className = this.GetType().Name;
        int typeStartIndex = className.IndexOf("Provider");
        string type = className.Substring(typeStartIndex);

        return $"{type} Provider – {this.Id}\nEnergy Output: {this.EnergyOutput}";
    }
}
