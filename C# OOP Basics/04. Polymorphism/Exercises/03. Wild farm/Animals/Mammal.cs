using System.Net.NetworkInformation;

abstract class Mammal : Animal
{
    protected string livingRegion;

    protected Mammal(string name, double weight, string livingRegion) 
        : base(name, weight)
    {
        this.livingRegion = livingRegion;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.name}, {this.weight}, {this.livingRegion}, {this.foodEaten}]";
    }
}
