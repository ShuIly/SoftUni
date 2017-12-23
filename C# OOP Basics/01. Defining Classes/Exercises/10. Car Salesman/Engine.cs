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

    public override string ToString()
    {
        return $"  {this.model}:\n" +
               $"    Power: {this.power}\n" +
               $"    Displacement: {this.displacements}\n" +
               $"    Efficiency: {this.efficiency}";
    }
}
