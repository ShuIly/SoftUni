using System;

class Cat : Feline
{
    private string breed;

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public Cat(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion)
    {
        this.breed = breed;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.name}, {this.breed}, {this.weight}, {this.livingRegion}, {this.foodEaten}]";
    }
}
