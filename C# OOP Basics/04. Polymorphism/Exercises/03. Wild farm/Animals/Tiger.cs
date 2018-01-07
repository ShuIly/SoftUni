using System;

class Tiger : Feline
{
    public Tiger(string name,  double weight, string livingRegion) 
        : base(name,  weight, livingRegion)
    {
    }

    public override string MakeSound()
    {
        return "ROAAR!!!";
    }

    public override void Eat(Food food)
    {
        if (!(food is Meat))
        {
            throw new ArgumentException("Tigers are not eating that type of food!");
        }

        base.Eat(food);
    }
}
