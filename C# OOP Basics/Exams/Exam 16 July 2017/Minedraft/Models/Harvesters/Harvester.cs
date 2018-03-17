using System;

public abstract class Harvester
{
    private const int MaxEnergyRequirement = 20000;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public string Id { get; private set; }

    public double OreOutput
    {
        get => this.oreOutput;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }

            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get => this.energyRequirement;
        protected set
        {
            if (value < 0 || value > MaxEnergyRequirement)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.EnergyRequirement)}");
            }

            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        string className = this.GetType().Name;
        int typeStartIndex = className.IndexOf("Harvester");
        string type = className.Substring(typeStartIndex);

        return $"{type} Harvester – {this.Id}\nOre Output: {this.oreOutput}\nEnergy Requirement: {this.EnergyRequirement}";
    }
}
