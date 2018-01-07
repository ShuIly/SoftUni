using System;

class Zebra : Mammal
{
    public Zebra(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "Zs";
    }

    public override void Eat(Food food)
    {
        if (!(food is Vegetable))
        {
            throw new ArgumentException("Zebras are not eating that type of food!");
        }

        base.Eat(food);
    }
}
