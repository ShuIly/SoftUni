using System;

class Engine
{
    private string model;
    private int power;
    private int displacements;
    private string efficiency;

    public Engine(string model, int power, int displacements, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacements = displacements;
        this.efficiency = efficiency;
    }

    public Engine(string model, int power)
        : this(model, power, -1, "n/a") { }

    public Engine(string model, int power, int displacements)
        : this(model, power, displacements, "n/a") { }

    public Engine(string model, int power, string efficiency)
        : this(model, power, -1, efficiency) { }

    public override string ToString()
    {
        return $"  {this.model}:\n" +
               $"    Power: {this.power}\n" +
               $"    Displacement: {(this.displacements == -1 ? "n/a" : this.displacements.ToString())}\n" +
               $"    Efficiency: {this.efficiency}\n";
    }
}
